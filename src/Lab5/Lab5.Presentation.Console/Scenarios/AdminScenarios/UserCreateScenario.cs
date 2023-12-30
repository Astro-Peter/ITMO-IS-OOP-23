using Lab5.Application.Contracts.Admin;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.AdminScenarios;

public class UserCreateScenario : IScenario
{
    private readonly IAdminService _adminService;

    public UserCreateScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Create User";
    public void Run()
    {
        string pinCode = AnsiConsole.Ask<string>("Input pin code");
        UserCreationResult result = _adminService.CreateUser(pinCode);
        if (result is UserCreationResult.Failure failure)
        {
            AnsiConsole.Ask<string>(failure.Message);
            AnsiConsole.Clear();
            return;
        }

        AnsiConsole.Ask<string>("User created successfully");
        AnsiConsole.Clear();
    }
}