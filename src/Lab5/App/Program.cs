using Itmo.Dev.Platform.Postgres.Models;
using Lab5.Application.Extensions;
using Lab5.Infrastructure.PostgreSQLDataAccess.Extensions;
using Lab5.Presentation.Console.Extensions;
using Lab5.Presentation.Console.Scenarios;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;

namespace App;

public static class Program
{
    public static void Main()
    {
        var collection = new ServiceCollection();

        var configuration = new PostgresConnectionConfiguration
        {
            Host = "localhost",
            Port = 6432,
            Username = "lab5",
            Password = "lab5",
            Database = "postgres",
            SslMode = "Prefer",
        };
        collection
            .AddApplication()
            .AddInfrastructureDataAccess(
                connectionConfiguration =>
                {
                    connectionConfiguration.Host = "localhost";
                    connectionConfiguration.Port = 6532;
                    connectionConfiguration.Username = "postgres";
                    connectionConfiguration.Password = "postgres";
                    connectionConfiguration.Database = "postgres";
                    connectionConfiguration.SslMode = "Prefer";
                })
            .AddPresentationConsole();

        ServiceProvider provider = collection.BuildServiceProvider();

        using IServiceScope scope = provider.CreateScope();

        scope.UseInfrastructureDataAccess();
        ScenarioRunner scenarioRunner = scope.ServiceProvider
            .GetRequiredService<ScenarioRunner>();
        while (true)
        {
            scenarioRunner.Run();
            AnsiConsole.Clear();
        }
    }
}