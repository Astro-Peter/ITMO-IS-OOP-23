using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;

public class ActionSelectionScenario : IScenario
{
    private readonly AddMoneyScenario _moneyScenario;
    private readonly GetBalanceScenario _balanceScenario;
    private readonly GetOperationsScenario _getOperationsScenario;
    private readonly RetrieveMoneyScenario _retrieveMoneyScenario;

    public ActionSelectionScenario(AddMoneyScenario moneyScenario, GetBalanceScenario balanceScenario, GetOperationsScenario getOperationsScenario, RetrieveMoneyScenario retrieveMoneyScenario)
    {
        _moneyScenario = moneyScenario;
        _balanceScenario = balanceScenario;
        _getOperationsScenario = getOperationsScenario;
        _retrieveMoneyScenario = retrieveMoneyScenario;
    }

    public string Name => "Action Selection";
    public void Run()
    {
        SelectionPrompt<IScenario> selection = new SelectionPrompt<IScenario>()
            .Title("Select Action")
            .AddChoices(new List<IScenario>
            {
                _moneyScenario,
                _retrieveMoneyScenario,
                _getOperationsScenario,
                _balanceScenario,
            })
            .UseConverter(x => x.Name);
        IScenario scenario = AnsiConsole.Prompt(selection);
        AnsiConsole.Clear();
        scenario.Run();
    }
}