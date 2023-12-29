namespace Lab5.Application.Contracts.User;

public abstract record UserOperationResult
{
    public record Success : UserOperationResult;

    public record Failure(string Message) : UserOperationResult;
}