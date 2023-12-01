using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Model;

public abstract record BuildResult
{
    public record BuildSuccess(IFileSystemCommand Command) : BuildResult;

    public record BuildFailure(string Message) : BuildResult;
}