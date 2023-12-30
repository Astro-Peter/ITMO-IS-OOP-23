using Lab5.Application.Models.User;

namespace Lab5.Application.Abstractions.Models;

public abstract record DbUserOperationResult
{
    public record Success(User User) : DbUserOperationResult;

    public record InsufficientFunds(User CurrentUser) : DbUserOperationResult;

    public record Failure(string Message) : DbUserOperationResult;
}