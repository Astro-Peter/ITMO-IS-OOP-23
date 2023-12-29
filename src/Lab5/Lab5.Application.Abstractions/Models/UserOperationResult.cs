using Lab5.Application.Models.User;

namespace Lab5.Application.Abstractions.Models;

public abstract record UserOperationResult
{
    public record Success(User User) : UserOperationResult;

    public record InsufficientFunds(User CurrentUser) : UserOperationResult;

    public record Failure(string Message) : UserOperationResult;
}