using FluentMigrator;

namespace Lab5.Infrastructure.PostgreSQLDataAccess.Migrations;

[Migration(2)]
public class Initial : Migration
{
    public override void Up()
    {
        Create.Table("users").WithColumn("accountid").AsInt32().PrimaryKey().Identity()
            .WithColumn("pincode").AsString(4).NotNullable()
            .WithColumn("moneyamount").AsFloat().WithDefault(0.0);

        Create.Table("operations")
            .WithColumn("operationid").AsInt64().PrimaryKey().Identity()
            .WithColumn("accountid").AsInt32().ForeignKey().ReferencedBy("users", "accountid")
            .WithColumn("startmoney").AsFloat().NotNullable()
            .WithColumn("moneydiff").AsFloat().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("users");
        Delete.Table("operations");
    }

    protected static string GetUpSql(IServiceProvider serviceProvider) =>
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

    protected static string GetDownSql(IServiceProvider serviceProvider) =>
        """
            DROP TABLE users CASCADE;
            DROP TABLE operations CASCADE;
        """;
}