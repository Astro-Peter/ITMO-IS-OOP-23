using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public class DeleteFileBuilder : ICommandWithPathBuilder
{
    private string? _path;
    public BuildResult Build()
    {
        if (_path is null)
        {
            return new BuildResult.BuildFailure("No path given");
        }

        return new BuildResult.BuildSuccess(new Delete(_path));
    }

    public void SetPath(string path)
    {
        _path = path;
    }
}