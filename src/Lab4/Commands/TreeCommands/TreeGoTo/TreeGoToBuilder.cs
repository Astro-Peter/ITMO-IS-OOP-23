using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands.TreeGoTo;

public class TreeGoToBuilder : ICommandWithPathBuilder
{
    private string? _path;
    public BuildResult Build()
    {
        if (_path is null)
        {
            return new BuildResult.BuildFailure("No path given");
        }

        return new BuildResult.BuildSuccess(new TreeGoTo(_path));
    }

    public void SetPath(string path)
    {
        _path = path;
    }
}