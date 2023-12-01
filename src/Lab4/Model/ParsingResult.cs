using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab4.Model;

public abstract record ParsingResult
{
    public record Success(ICommandBuilder Builder) : ParsingResult;

    public record IncorrectLink : ParsingResult;

    public record Failure(string Issue) : ParsingResult;
}