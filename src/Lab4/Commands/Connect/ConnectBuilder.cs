using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Connect;

public class ConnectBuilder : ICommandWithPathBuilder, ICommandWithModeBuilder
{
    private string? _name;
    private string? _mode;

    public void SetPath(string path)
    {
        _name = path;
    }

    public void SetMode(string mode)
    {
        _mode = mode;
    }

    public BuildResult Build()
    {
        if (_name is null)
        {
            return new BuildResult.BuildFailure("Path was not given");
        }

        if (_mode is null)
        {
            return new BuildResult.BuildFailure("Mode was not given");
        }

        return new BuildResult.BuildSuccess(new Commands.Connect.Connect(_name, _mode));
    }
}