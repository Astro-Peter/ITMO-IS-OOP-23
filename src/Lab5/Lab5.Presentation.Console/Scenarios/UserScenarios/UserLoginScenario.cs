using Lab5.Application.Contracts.User;
using Lab5.Presentation.Console.Scenarios.UserScenarios.UserScenariosProvider;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class UserLoginScenario : IScenario
{
    private readonly IUserLoginService _loginService;
    private readonly IUserScenarioProvider _scenarioProvider;
    private readonly IActionSelectionScenario _selectionScenario;

    public UserLoginScenario(IUserLoginService loginService, IActionSelectionScenario selectionScenario, IUserScenarioProvider scenarioProvider)
    {
        _loginService = loginService;
        _selectionScenario = selectionScenario;
        _scenarioProvider = scenarioProvider;
    }

    public string Name => "User Login";
    public void Run()
    {
        int accountId = AnsiConsole.Ask<int>("Enter account ID");
        string pinCode = AnsiConsole.Ask<string>("Enter pin code");

        UserLoginResult loginResult = _loginService.Login(accountId, pinCode);
        AnsiConsole.Clear();
        if (loginResult is UserLoginResult.Failure failure)
        {
            AnsiConsole.Ask<string>(failure.Message);
        }

        if (loginResult is UserLoginResult.Success)
        {
            _selectionScenario.SetScenarioProvider(_scenarioProvider);
            _selectionScenario.Run();
        }
    }
}