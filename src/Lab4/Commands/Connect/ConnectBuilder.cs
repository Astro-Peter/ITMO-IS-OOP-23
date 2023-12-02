using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Connect;

public class ConnectBuilder : ICommandWithPathBuilder, ICommandWithFileSystemBuilder
{
    private string? _name;
    private IFileSystem? _fileSystem;

    public void SetPath(string path)
    {
        _name = path;
    }

    public void SetFileSystem(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
    }

    public BuildResult Build()
    {
        if (_name is null)
        {
            return new BuildResult.BuildFailure("Path was not given");
        }

        if (_fileSystem is null)
        {
            return new BuildResult.BuildFailure("File System was not given");
        }

        return new BuildResult.BuildSuccess(new Commands.Connect.Connect(_name, _fileSystem));
    }
}