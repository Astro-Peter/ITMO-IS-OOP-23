namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.ContextState;

public interface IContextState
{
    public IContextState Connect();
    public IContextState Disconnect();
}