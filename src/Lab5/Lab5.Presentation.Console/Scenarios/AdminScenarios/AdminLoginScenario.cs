using Lab5.Application.Contracts.Admin;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AdminScenarios;

public class AdminLoginScenario : IScenario
{
    private readonly IAdminLoginService _loginService;
    private readonly UserCreateScenario _userCreateScenario;

    public AdminLoginScenario(IAdminLoginService loginService, UserCreateScenario userCreateScenario)
    {
        _loginService = loginService;
        _userCreateScenario = userCreateScenario;
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
            _userCreateScenario.Run();
        }
    }
}