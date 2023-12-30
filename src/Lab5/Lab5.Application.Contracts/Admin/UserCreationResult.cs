namespace Lab5.Application.Contracts.Admin;

public abstract record UserCreationResult
{
    public record Success : UserCreationResult;

    public record Failure(string Message) : UserCreationResult;
}