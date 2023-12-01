using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Connect;

public class Connect : IFileSystemCommand
{
    private readonly string _address;
    private readonly string _mode;

    public Connect(string address, string mode)
    {
        _address = address;
        _mode = mode;
    }

    public CommandResult Execute(IContext context)
    {
        if (_mode != "local")
        {
            return new CommandResult.Failure("unknown mode");
        }

        var fileSystem = new LocalFileSystem();
        FileSystemResult result = fileSystem.SetPath(_address);
        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        context.Connect(fileSystem);
        return new CommandResult.Success();
    }
}