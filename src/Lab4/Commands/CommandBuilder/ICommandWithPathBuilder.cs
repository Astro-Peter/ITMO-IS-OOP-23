namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public interface ICommandWithPathBuilder : ICommandBuilder
{
    public void SetPath(string path);
}