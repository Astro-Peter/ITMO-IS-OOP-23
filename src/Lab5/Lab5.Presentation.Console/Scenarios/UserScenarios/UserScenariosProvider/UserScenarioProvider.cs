using Lab5.Application.Contracts.User;
using Lab5.Presentation.Console.Scenarios.UserScenarios.OperationScenarios;

namespace Lab5.Presentation.Console.Scenarios.UserScenarios.UserScenariosProvider;

public class UserScenarioProvider : IUserScenarioProvider
{
    private readonly IUserService _userService;

    public UserScenarioProvider(IUserService userService)
    {
        _userService = userService;
    }

    public IEnumerable<IScenario> GetScenarios()
    {
        return new List<IScenario>
        {
            new AddMoneyScenario(_userService),
            new RetrieveMoneyScenario(_userService),
            new GetBalanceScenario(_userService),
            new GetOperationsScenario(_userService),
        };
    }
}