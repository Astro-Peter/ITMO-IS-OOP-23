namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public interface ICommandWithTwoPathsBuilder : ICommandWithPathBuilder
{
    public void SetSecondPath(string path);
}