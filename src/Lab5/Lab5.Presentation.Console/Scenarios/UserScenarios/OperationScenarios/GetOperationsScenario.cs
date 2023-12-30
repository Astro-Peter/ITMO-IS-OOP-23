using System.Globalization;
using Lab5.Application.Contracts.User;
using Lab5.Application.Models.Operation;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;

public class GetOperationsScenario : IScenario
{
    private readonly IUserService _userService;

    public GetOperationsScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Get Operations";

    public void Run()
    {
        UserOperationResult result = _userService.GetUserOperations();
        if (result is UserOperationResult.Failure failure)
        {
            AnsiConsole.Ask<string>(failure.Message);
        }

        if (result is UserOperationResult.UserOperations operations)
        {
            var table = new Table();
            table.AddColumn("Start Amount");
            table.AddColumn("Change");
            table.AddColumn("OperationID");
            foreach (Operation operation in operations.Operations)
            {
                table.AddRow(
                    Convert.ToString(operation.AmountBefore, CultureInfo.InvariantCulture),
                    Convert.ToString(operation.Change, CultureInfo.InvariantCulture),
                    Convert.ToString(operation.OperationId, CultureInfo.InvariantCulture));
            }

            AnsiConsole.Write(table);
            AnsiConsole.Ask<string>("Waiting");
        }

        AnsiConsole.Clear();
    }
}