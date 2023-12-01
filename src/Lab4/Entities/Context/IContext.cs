using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;

public interface IContext
{
    public IFileSystem FileSystem { get; }
    public void Connect(IFileSystem fileSystem);
    public void Disconnect();
}