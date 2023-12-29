namespace Lab5.Application.Contracts.User;

public interface IUserLoginService
{
    UserLoginResult Login(string accountId, string pinCode);
}