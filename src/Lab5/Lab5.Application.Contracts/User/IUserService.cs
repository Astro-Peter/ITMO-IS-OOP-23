using Lab5.Application.Models.Operation;

namespace Lab5.Application.Contracts.User;

public interface IUserService
{
    public float GetBalance();
    public UserOperationResult AddMoney(float amount);
    public UserOperationResult RetrieveMoney(float amount);
    public IEnumerable<Operation> GetUserOperations();
}