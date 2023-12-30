using Lab5.Application.AdminServices;
using Lab5.Application.Contracts.Admin;
using Lab5.Application.Contracts.User;
using Lab5.Application.UserServices;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserLoginService, UserLoginService>();
        collection.AddScoped<IAdminService, AdminService>();
        collection.AddScoped<IAdminLoginService, AdminLoginService>();

        collection.AddScoped<UserService>();
        collection.AddScoped<IUserService>(
            p => p.GetRequiredService<UserService>());

        return collection;
    }
}