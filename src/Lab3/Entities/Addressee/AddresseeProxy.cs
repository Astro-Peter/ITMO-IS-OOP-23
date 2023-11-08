using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class AddresseeProxy : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly int _priorityLevel;

    public AddresseeProxy(IAddressee addressee, int priorityLevel)
    {
        _addressee = addressee;
        _priorityLevel = priorityLevel;
    }

    public void ReceiveMessage(Message message)
    {
        if (message.PriorityLevel >= _priorityLevel) _addressee.ReceiveMessage(message);
    }
}