using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.User;
using Lab5.Application.Models.User;

namespace Lab5.Application.UserServices;

public class UserLoginService : IUserLoginService
{
    private readonly IUserRepository _userRepository;
    private readonly UserService _userService;

    public UserLoginService(IUserRepository userRepository, UserService userService)
    {
        _userRepository = userRepository;
        _userService = userService;
    }

    public UserLoginResult Login(int accountId, string pinCode)
    {
        User? user = _userRepository.GetUser(accountId, pinCode);
        if (user is null)
        {
            return new UserLoginResult.Failure("Incorrect login data");
        }

        _userService.User = user;
        return new UserLoginResult.Success();
    }
}