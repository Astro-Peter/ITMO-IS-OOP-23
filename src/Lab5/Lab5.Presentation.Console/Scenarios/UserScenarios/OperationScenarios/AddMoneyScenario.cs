using Lab5.Application.Contracts.User;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;

public class AddMoneyScenario : IScenario
{
    private readonly IUserService _userService;

    public AddMoneyScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Add Money";

    public void Run()
    {
        float amount = AnsiConsole.Ask<float>("Set amount of money to add");
        if (amount < 0)
        {
            AnsiConsole.WriteLine("Amount should be positive");
            return;
        }

        UserOperationResult result = _userService.ChangeMoney(amount);

        if (result is UserOperationResult.Failure failure)
        {
            AnsiConsole.WriteLine(failure.Message);
        }

        if (result is UserOperationResult.Success)
        {
            AnsiConsole.WriteLine("Money added successfully");
        }

        AnsiConsole.Ask<string>("Waiting");
        AnsiConsole.Clear();
    }
}