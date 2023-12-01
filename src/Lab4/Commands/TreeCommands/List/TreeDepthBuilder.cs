using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands.List;

public class TreeDepthBuilder : ICommandWithDepthBuilder
{
    private int? _depth;
    private ITreeFormatter _treeFormatter = new TreeFormatter(new ConsolePrinter());

    public void SetDepth(int depth)
    {
        _depth = depth;
    }

    public BuildResult Build()
    {
        if (_depth is null)
        {
            return new BuildResult.BuildFailure("Depth was not given");
        }

        return new BuildResult.BuildSuccess(new TreeList(_treeFormatter, _depth.Value));
    }
}