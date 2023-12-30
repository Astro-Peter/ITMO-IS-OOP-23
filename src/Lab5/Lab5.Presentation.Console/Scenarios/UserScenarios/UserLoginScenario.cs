using Lab5.Application.Contracts.User;
using Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios;

public class UserLoginScenario : IScenario
{
    private readonly IUserLoginService _loginService;
    private readonly ActionSelectionScenario _selectionScenario;

    public UserLoginScenario(IUserLoginService loginService, ActionSelectionScenario selectionScenario)
    {
        _loginService = loginService;
        _selectionScenario = selectionScenario;
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
            _selectionScenario.Run();
        }
    }
}