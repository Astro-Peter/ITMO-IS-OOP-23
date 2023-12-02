using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Delete;

public class Delete : IFileSystemCommand
{
    private readonly string _fileName;

    public Delete(string fileName)
    {
        _fileName = fileName;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult result = context.FileSystem.DeleteFile(_fileName);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        return new CommandResult.Success();
    }
}