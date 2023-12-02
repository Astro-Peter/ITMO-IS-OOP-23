using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Connect;

public class Connect : IFileSystemCommand
{
    private readonly string _address;
    private readonly IFileSystem _fileSystem;

    public Connect(string address, IFileSystem fileSystem)
    {
        _address = address;
        _fileSystem = fileSystem;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult result = _fileSystem.SetPath(_address);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        context.Connect(_fileSystem);
        return new CommandResult.Success();
    }
}