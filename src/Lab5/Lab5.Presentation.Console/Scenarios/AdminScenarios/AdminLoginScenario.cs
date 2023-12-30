using Lab5.Application.Contracts.Admin;
using Lab5.Presentation.Console.Scenarios.AdminScenarios.AdminScenariosProvider;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AdminScenarios;

public class AdminLoginScenario : IScenario
{
    private readonly IActionSelectionScenario _selectionScenario;
    private readonly IAdminScenarioProvider _scenarioProvider;
    private readonly IAdminLoginService _loginService;

    public AdminLoginScenario(IAdminLoginService loginService, IAdminScenarioProvider scenarioProvider, IActionSelectionScenario selectionScenario)
    {
        _loginService = loginService;
        _scenarioProvider = scenarioProvider;
        _selectionScenario = selectionScenario;
    }

    public string Name => "Admin Login";

    public void Run()
    {
        string password = AnsiConsole.Ask<string>("Enter admin password");

        AdminLoginResult loginResult = _loginService.Login(password);
        AnsiConsole.Clear();
        if (loginResult is AdminLoginResult.Failure failure)
        {
            AnsiConsole.Ask<string>(failure.Message);
        }

        if (loginResult is AdminLoginResult.Success)
        {
            _selectionScenario.SetScenarioProvider(_scenarioProvider);
            _selectionScenario.Run();
        }
    }
}