namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public interface ICommandWithDepthBuilder : ICommandBuilder
{
    public void SetDepth(int depth);
}