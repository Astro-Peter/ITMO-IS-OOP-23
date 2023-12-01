using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class MoveFile : IFileSystemCommand
{
    private string _filePath;
    private string _newPath;

    public MoveFile(string filePath, string newPath)
    {
        _filePath = filePath;
        _newPath = newPath;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult result = context.FileSystem.MoveFile(_filePath, _newPath);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        return new CommandResult.Success();
    }
}