using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Disconnect;

public class Disconnect : IFileSystemCommand
{
    public CommandResult Execute(IContext context)
    {
        context.Disconnect();
        return new CommandResult.Success();
    }
}