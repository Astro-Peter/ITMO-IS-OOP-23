namespace Lab5.Application.Contracts.User;

public interface IUserLoginService
{
    UserLoginResult Login(int accountId, string pinCode);
}