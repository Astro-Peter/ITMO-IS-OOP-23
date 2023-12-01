using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public class RenameFileBuilder : ICommandWithTwoPathsBuilder
{
    private string? _filePath;
    private string? _newName;

    public BuildResult Build()
    {
        if (_filePath is null)
        {
            return new BuildResult.BuildFailure("File path is undefined");
        }

        if (_newName is null)
        {
            return new BuildResult.BuildFailure("New name is undefined");
        }

        return new BuildResult.BuildSuccess(new FileRename(_filePath, _newName));
    }

    public void SetPath(string path)
    {
        _filePath = path;
    }

    public void SetSecondPath(string path)
    {
        _newName = path;
    }
}