using Lab5.Application.Abstractions.Models;
using Lab5.Application.Models.User;

namespace Lab5.Application.Abstractions.Repositories;

public interface IUserRepository
{
    public void AddUser(string pinCode);
    public User? GetUser(int accountId, string pinCode);
    public UserOperationResult ChangeUserMoney(User user, float amount);
}