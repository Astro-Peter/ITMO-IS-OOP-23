namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ContextState;

public class ConnectedState : IContextState
{
    public IContextState Connect()
    {
        return this;
    }

    public IContextState Disconnect()
    {
        return new DisconnectedState();
    }
}