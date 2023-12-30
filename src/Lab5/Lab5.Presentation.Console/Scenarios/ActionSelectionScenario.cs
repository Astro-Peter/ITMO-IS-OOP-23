using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios;

public class ActionSelectionScenario : IActionSelectionScenario
{
    private IScenarioProvider? _scenarioProvider;

    public string Name => "Action Selection";

    public void Run()
    {
        if (_scenarioProvider is null)
        {
            AnsiConsole.Ask<string>("No actions available");
            AnsiConsole.Clear();
            return;
        }

        SelectionPrompt<IScenario> selection = new SelectionPrompt<IScenario>()
            .Title("Select Action")
            .AddChoices(_scenarioProvider.GetScenarios())
            .UseConverter(x => x.Name);
        IScenario scenario = AnsiConsole.Prompt(selection);
        AnsiConsole.Clear();
        scenario.Run();
    }

    public void SetScenarioProvider(IScenarioProvider scenarioProvider)
    {
        _scenarioProvider = scenarioProvider;
    }
}