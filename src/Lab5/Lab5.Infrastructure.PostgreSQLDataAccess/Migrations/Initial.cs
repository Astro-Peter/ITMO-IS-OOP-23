using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5.Infrastructure.PostgreSQLDataAccess.Migrations;

[Migration(1, "Initial")]

public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """
        CREATE TABLE users
        (
            AccountId INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY ,
            PinCode CHAR(4) NOT NULL ,
            MoneyAmount FLOAT NOT NULL DEFAULT 0.0 CONSTRAINT moneyPositive CHECK ( MoneyAmount >= 0 )
        );

        CREATE TABLE operations
        (
            OperationID BIGINT PRIMARY KEY GENERATED ALWAYS AS IDENTITY ,
            AccountId INT REFERENCES users(AccountId) ,
            StartMoney FLOAT CONSTRAINT startMoneyPositive CHECK ( StartMoney >= 0 ) ,
            MoneyDiff FLOAT CONSTRAINT operationResultPositive CHECK ( StartMoney + operations.MoneyDiff >= 0 )
        );
        """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
    """
        DROP TABLE users CASCADE;
        DROP TABLE operations CASCADE;
    """;
}