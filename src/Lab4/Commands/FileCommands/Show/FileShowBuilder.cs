using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Show;

public class FileShowBuilder : ICommandWithPathBuilder, ICommandWithModeBuilder
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
        if (_mode is null)
        {
            return new BuildResult.BuildFailure("Mode not defined");
        }

        if (_name is null)
        {
            return new BuildResult.BuildFailure("File name not defined");
        }

        return new BuildResult.BuildSuccess(new FileShow(_name, _mode));
    }
}