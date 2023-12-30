using System.Runtime.CompilerServices;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Models.Operation;
using Npgsql;

namespace Lab5.Infrastructure.PostgreSQLDataAccess.Repositories;

public class OperationRepository : IOperationRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public OperationRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public IEnumerable<Operation> GetAllOperations(int accountId)
    {
        const string sql =
            """
            SELECT startmoney, moneydiff, operationid
            FROM operations
            WHERE accountid = :accountId;
            """;

        ConfiguredTaskAwaitable<NpgsqlConnection> connectionAwaiter = _connectionProvider
            .GetConnectionAsync(default)
            .AsTask()
            .ConfigureAwait(false);
        NpgsqlConnection connection = connectionAwaiter.GetAwaiter().GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountId", accountId);

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            yield return new Operation(
                reader.GetDouble(0),
                reader.GetDouble(1),
                reader.GetInt64(2));
        }
    }
}