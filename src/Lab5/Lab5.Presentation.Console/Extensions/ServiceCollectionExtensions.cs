using Lab5.Presentation.Console.Scenarios;
using Lab5.Presentation.Console.Scenarios.AdminScenarios;
using Lab5.Presentation.Console.Scenarios.UserScenarios;
using Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Console.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();

        collection.AddScoped<UserLoginScenario>();

        collection.AddScoped<ActionSelectionScenario>();

        collection.AddScoped<RetrieveMoneyScenario>();
        collection.AddScoped<AddMoneyScenario>();
        collection.AddScoped<GetOperationsScenario>();
        collection.AddScoped<GetBalanceScenario>();

        collection.AddScoped<AdminLoginScenario>();

        collection.AddScoped<UserCreateScenario>();

        return collection;
    }
}