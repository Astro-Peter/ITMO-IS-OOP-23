using Lab5.Application.Contracts.Admin;

namespace Lab5.Presentation.Console.Scenarios.AdminScenarios.AdminScenariosProvider;

public class AdminScenarioProvider : IAdminScenarioProvider
{
    private readonly IAdminService _adminService;

    public AdminScenarioProvider(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public IEnumerable<IScenario> GetScenarios()
    {
        return new List<IScenario>()
        {
            new UserCreateScenario(_adminService),
        };
    }
}