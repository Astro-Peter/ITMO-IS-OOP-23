namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ContextState;

public class DisconnectedState : IContextState
{
    public IContextState Connect()
    {
        return new ConnectedState();
    }

    public IContextState Disconnect()
    {
        return this;
    }
}