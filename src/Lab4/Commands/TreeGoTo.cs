using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class TreeGoTo : IFileSystemCommand
{
    private string _newPath;

    public TreeGoTo(string newPath)
    {
        _newPath = newPath;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult result = context.FileSystem.SetPath(_newPath);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        return new CommandResult.Success();
    }
}