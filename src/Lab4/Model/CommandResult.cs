namespace Itmo.ObjectOrientedProgramming.Lab4.Model;

public abstract record CommandResult
{
    public record Success(string Result = "ok") : CommandResult;

    public record Failure(string Result) : CommandResult;
}