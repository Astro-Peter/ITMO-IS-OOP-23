using Lab5.Presentation.Console.Scenarios;
using Lab5.Presentation.Console.Scenarios.AdminScenarios.AdminScenariosProvider;
using Lab5.Presentation.Console.Scenarios.UserScenarios.UserScenariosProvider;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Console.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();

        collection.AddScoped<IStartScenarioProvider, StartScenarioProvider>();

        collection.AddScoped<IActionSelectionScenario, ActionSelectionScenario>();

        collection.AddScoped<IAdminScenarioProvider, AdminScenarioProvider>();

        collection.AddScoped<IUserScenarioProvider, UserScenarioProvider>();

        return collection;
    }
}