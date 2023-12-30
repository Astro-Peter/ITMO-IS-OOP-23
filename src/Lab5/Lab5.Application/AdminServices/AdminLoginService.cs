using Lab5.Application.Contracts.Admin;

namespace Lab5.Application.AdminServices;

public class AdminLoginService : IAdminLoginService
{
    public AdminLoginResult Login(string password)
    {
        if (password == Environment.GetEnvironmentVariable("adminPassword"))
        {
            return new AdminLoginResult.Success();
        }

        return new AdminLoginResult.Failure("Incorrect password");
    }
}