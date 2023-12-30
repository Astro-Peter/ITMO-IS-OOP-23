namespace Lab5.Presentation.Console.Scenarios;

public class ScenarioRunner
{
    private readonly IStartScenarioProvider _scenarioProvider;
    private readonly IActionSelectionScenario _selectionScenario;

    public ScenarioRunner(IStartScenarioProvider scenarioProvider, IActionSelectionScenario selectionScenario)
    {
        _scenarioProvider = scenarioProvider;
        _selectionScenario = selectionScenario;
    }

    public void Run()
    {
        _selectionScenario.SetScenarioProvider(_scenarioProvider);
        _selectionScenario.Run();
    }
}