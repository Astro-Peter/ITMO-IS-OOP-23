using System.Runtime.CompilerServices;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Models;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Models.User;
using Npgsql;

namespace Lab5.Infrastructure.PostgreSQLDataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UserRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public void AddUser(string pinCode)
    {
        const string sql =
            """
            INSERT INTO users(pincode)
            VALUES (:pinCode);
            """;

        ConfiguredTaskAwaitable<NpgsqlConnection> connectionAwaiter = _connectionProvider
            .GetConnectionAsync(default)
            .AsTask()
            .ConfigureAwait(false);
        NpgsqlConnection connection = connectionAwaiter.GetAwaiter().GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("pinCode", pinCode);
        command.ExecuteNonQuery();
    }

    public User? GetUser(int accountId, string pinCode)
    {
        const string sql =
            """
            SELECT MoneyAmount
            FROM users
            WHERE accountid = :accountId AND pincode = :pinCode;
            """;

        ConfiguredTaskAwaitable<NpgsqlConnection> connectionAwaiter = _connectionProvider
            .GetConnectionAsync(default)
            .AsTask()
            .ConfigureAwait(false);
        NpgsqlConnection connection = connectionAwaiter.GetAwaiter().GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountId", accountId)
            .AddParameter("pinCode", pinCode);

        using NpgsqlDataReader reader = command.ExecuteReader();
        if (reader.Read() == false)
        {
            return null;
        }

        return new User(accountId, pinCode, reader.GetFloat(0));
    }

    public UserOperationResult ChangeUserMoney(User user, float amount)
    {
        const string sql =
            """
            SELECT MoneyAmount
            FROM users
            WHERE accountid = :accountId AND pincode = :pinCode;
            """;

        ConfiguredTaskAwaitable<NpgsqlConnection> connectionAwaiter = _connectionProvider
            .GetConnectionAsync(default)
            .AsTask()
            .ConfigureAwait(false);
        NpgsqlConnection connection = connectionAwaiter.GetAwaiter().GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountId", user.UserId)
            .AddParameter("pinCode", user.PinCode);

        using NpgsqlDataReader reader = command.ExecuteReader();
        if (reader.Read() == false)
        {
            return new UserOperationResult.Failure("Account details incorrect");
        }

        float money = reader.GetFloat(0);
        if (money + amount < 0)
        {
            return new UserOperationResult.InsufficientFunds(new User(user.UserId, user.PinCode, money));
        }

        reader.Dispose();
        command.Dispose();

        const string sql2 =
            """
            INSERT INTO operations(accountid, startmoney, moneydiff)
            VALUES (:accountId, :startMoney, :moneyDiff);
            """;

        using var command2 = new NpgsqlCommand(sql2, connection);
        command2.AddParameter("accountId", user.UserId)
            .AddParameter("startMoney", money)
            .AddParameter("moneyDiff", amount);

        command2.ExecuteNonQuery();

        command2.Dispose();

        const string sql3 =
            """
            UPDATE users
            SET moneyamount = :money
            WHERE accountid = :accountId;
            """;

        using var command3 = new NpgsqlCommand(sql3, connection);
        command3.AddParameter("money", money - amount)
            .AddParameter("accountId", user.UserId);
        command3.ExecuteNonQuery();

        return new UserOperationResult.Success(new User(user.UserId, user.PinCode, money - amount));
    }
}