using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileRename : IFileSystemCommand
{
    private string _filePath;
    private string _newName;

    public FileRename(string filePath, string newName)
    {
        _filePath = filePath;
        _newName = newName;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult result = context.FileSystem.RenameFile(_filePath, _newName);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        return new CommandResult.Success();
    }
}