using FluentMigrator.Runner;
using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Models;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Infrastructure.PostgreSQLDataAccess.Migrations;
using Lab5.Infrastructure.PostgreSQLDataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Infrastructure.PostgreSQLDataAccess.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureDataAccess(
        this IServiceCollection collection,
        Action<PostgresConnectionConfiguration> configuration,
        string connectionString)
    {
        collection.AddPlatformPostgres(builder => builder.Configure(configuration));
        collection.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb.AddPostgres11_0()
                .WithGlobalConnectionString(connectionString)
                .ScanIn(typeof(Initial).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            .BuildServiceProvider(false);

        collection.AddScoped<IUserRepository, UserRepository>();
        collection.AddScoped<IOperationRepository, OperationRepository>();

        return collection;
    }
}