using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageAdapter;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Traits;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class UserAddressee : IAddressee
{
    public UserAddressee(IList<ITrait>? traits = null)
    {
        Traits = traits ?? new List<ITrait>();
    }

    public IList<ITrait> Traits { get; }
    public IList<IMessageAdapter> Messages { get; } = new List<IMessageAdapter>();

    public void ReceiveMessage(Message message)
    {
        Messages.Add(new MessageAdapter.MessageAdapter(message));
    }
}