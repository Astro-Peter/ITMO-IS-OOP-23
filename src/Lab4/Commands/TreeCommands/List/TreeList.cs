using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands.List;

public class TreeList : IFileSystemCommand
{
    private readonly int _depth;
    private readonly ITreeFormatter _formatter;

    public TreeList(ITreeFormatter formatter, int depth)
    {
        _formatter = formatter;
        _depth = depth;
    }

    public CommandResult Execute(IContext context)
    {
        FileSystemResult files = context.FileSystem.GetTree(_depth);
        if (files is FileSystemResult.TreeResult tree)
        {
            tree.Result.Accept(_formatter);
            return new CommandResult.Success();
        }

        if (files is FileSystemResult.Failure f)
        {
            return new CommandResult.Failure(f.Issue);
        }

        return new CommandResult.Failure("Something went wrong");
    }
}