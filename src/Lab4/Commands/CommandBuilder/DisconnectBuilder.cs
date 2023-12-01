using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public class DisconnectBuilder : ICommandBuilder
{
    public BuildResult Build()
    {
        return new BuildResult.BuildSuccess(new Disconnect());
    }
}