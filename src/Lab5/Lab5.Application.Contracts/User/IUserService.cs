namespace Lab5.Application.Contracts.User;

public interface IUserService
{
    public UserOperationResult GetBalance();
    public UserOperationResult ChangeMoney(float amount);
    public UserOperationResult GetUserOperations();
}