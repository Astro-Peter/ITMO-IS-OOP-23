using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public interface ICommandWithFileSystemBuilder : ICommandBuilder
{
    public void SetFileSystem(IFileSystem fileSystem);
}