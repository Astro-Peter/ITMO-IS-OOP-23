namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public interface ICommandWithModeBuilder : ICommandBuilder
{
    public void SetMode(string mode);
}