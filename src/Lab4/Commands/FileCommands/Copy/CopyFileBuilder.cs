using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Copy;

public class CopyFileBuilder : ICommandWithTwoPathsBuilder
{
    private string? _filePath;
    private string? _destinationPath;

    public BuildResult Build()
    {
        if (_filePath is null)
        {
            return new BuildResult.BuildFailure("File path is undefined");
        }

        if (_destinationPath is null)
        {
            return new BuildResult.BuildFailure("Destination is undefined");
        }

        return new BuildResult.BuildSuccess(new CopyFile(_filePath, _destinationPath));
    }

    public void SetPath(string path)
    {
        _filePath = path;
    }

    public void SetSecondPath(string path)
    {
        _destinationPath = path;
    }
}