using Lab5.Presentation.Console.Scenarios.AdminScenarios;
using Lab5.Presentation.Console.Scenarios.UserScenarios;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios;

public class ScenarioRunner
{
    private readonly UserLoginScenario _userLoginScenario;
    private readonly AdminLoginScenario _adminLoginScenario;

    public ScenarioRunner(UserLoginScenario userLoginScenario, AdminLoginScenario adminLoginScenario)
    {
        _userLoginScenario = userLoginScenario;
        _adminLoginScenario = adminLoginScenario;
    }

    public void Run()
    {
        SelectionPrompt<IScenario> selection = new SelectionPrompt<IScenario>()
            .Title("Select Mode")
            .AddChoices(
                new List<IScenario>
                {
                    _adminLoginScenario,
                    _userLoginScenario,
                })
            .UseConverter(x => x.Name);
        IScenario scenario = AnsiConsole.Prompt(selection);
        AnsiConsole.Clear();
        scenario.Run();
    }
}