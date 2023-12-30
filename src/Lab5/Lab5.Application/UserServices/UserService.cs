using Lab5.Application.Abstractions.Models;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.User;
using Lab5.Application.Models.User;

namespace Lab5.Application.UserServices;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IOperationRepository _operationRepository;

    public UserService(IUserRepository userRepository, IOperationRepository operationRepository)
    {
        _userRepository = userRepository;
        _operationRepository = operationRepository;
    }

    public User? User { get; set; }

    public UserOperationResult GetBalance()
    {
        if (User is null)
        {
            return new UserOperationResult.Failure("User is not available");
        }

        return new UserOperationResult.Money(User.Money);
    }

    public UserOperationResult ChangeMoney(float amount)
    {
        if (User is null)
        {
            return new UserOperationResult.Failure("User is not available");
        }

        DbUserOperationResult attempt = _userRepository.ChangeUserMoney(User, amount);
        if (attempt is DbUserOperationResult.Failure failure)
        {
            return new UserOperationResult.Failure(failure.Message);
        }

        if (attempt is DbUserOperationResult.Success success)
        {
            User = success.User;
            return new UserOperationResult.Success();
        }

        if (attempt is DbUserOperationResult.InsufficientFunds insufficientFunds)
        {
            User = insufficientFunds.CurrentUser;
            return new UserOperationResult.Failure("Not enough money");
        }

        return new UserOperationResult.Failure("Unknown issue appeared");
    }

    public UserOperationResult GetUserOperations()
    {
        if (User is null)
        {
            return new UserOperationResult.Failure("User is not available");
        }

        return new UserOperationResult.UserOperations(_operationRepository.GetAllOperations(User.UserId));
    }
}