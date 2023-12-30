using Lab5.Application.Contracts.User;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;

public class RetrieveMoneyScenario : IScenario
{
    private readonly IUserService _userService;

    public RetrieveMoneyScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Retrieve Money";
    public void Run()
    {
        float amount = AnsiConsole.Ask<float>("Set amount of money to retrieve");
        if (amount < 0)
        {
            AnsiConsole.WriteLine("Amount should be positive");
            return;
        }

        UserOperationResult result = _userService.ChangeMoney(-amount);

        if (result is UserOperationResult.Failure failure)
        {
            AnsiConsole.WriteLine(failure.Message);
        }

        if (result is UserOperationResult.Success)
        {
            AnsiConsole.WriteLine("Money retrieved successfully");
        }

        AnsiConsole.Ask<string>("Waiting");
        AnsiConsole.Clear();
    }
}