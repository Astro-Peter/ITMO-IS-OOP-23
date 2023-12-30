using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.Admin;

namespace Lab5.Application.AdminServices;

public class AdminService : IAdminService
{
    private readonly IUserRepository _userRepository;

    public AdminService(IUserRepository repository)
    {
        _userRepository = repository;
    }

    public UserCreationResult CreateUser(string pinCode)
    {
        if (!int.TryParse(pinCode, out _))
        {
            return new UserCreationResult.Failure("Pin code has characters which are not numbers");
        }

        if (pinCode.Length != 4)
        {
            return new UserCreationResult.Failure("Incorrect length of the pin code");
        }

        _userRepository.AddUser(pinCode);
        return new UserCreationResult.Success();
    }
}