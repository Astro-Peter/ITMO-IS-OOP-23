using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Disconnect;

public class DisconnectBuilder : ICommandBuilder
{
    public BuildResult Build()
    {
        return new BuildResult.BuildSuccess(new Commands.Disconnect.Disconnect());
    }
}