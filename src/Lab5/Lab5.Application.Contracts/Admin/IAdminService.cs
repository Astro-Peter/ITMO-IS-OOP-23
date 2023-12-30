namespace Lab5.Application.Contracts.Admin;

public interface IAdminService
{
    UserCreationResult CreateUser(string pinCode);
}