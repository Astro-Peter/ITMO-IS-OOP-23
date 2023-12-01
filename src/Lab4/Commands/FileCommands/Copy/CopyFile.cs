using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Copy;

public class CopyFile : IFileSystemCommand
{
    private string _filePath;
    private string _newPath;

    public CopyFile(string filePath, string newPath)
    {
        _filePath = filePath;
        _newPath = newPath;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult result = context.FileSystem.CopyFile(_filePath, _newPath);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        return new CommandResult.Success();
    }
}