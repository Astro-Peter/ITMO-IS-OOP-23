namespace Lab5.Application.Contracts.User;

public abstract record UserLoginResult
{
    public record Success(IUserService User) : UserLoginResult;

    public record Failure(string Message) : UserLoginResult;
}