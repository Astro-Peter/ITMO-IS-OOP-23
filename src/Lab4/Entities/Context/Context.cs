using Itmo.ObjectOrientedProgramming.Lab4.Entities.ContextState;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;

public class Context : IContext
{
    private IContextState _state = new DisconnectedState();
    public IFileSystem FileSystem { get; private set; } = new NullFileSystem();

    public void Connect(IFileSystem fileSystem)
    {
        if (_state is DisconnectedState)
        {
            _state = new ConnectedState();
            FileSystem = fileSystem;
        }
    }

    public void Disconnect()
    {
        _state = new DisconnectedState();
        FileSystem = new NullFileSystem();
    }
}