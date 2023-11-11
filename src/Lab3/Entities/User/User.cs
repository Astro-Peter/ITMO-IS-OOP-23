using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.User;

public class User : IUser
{
    public IList<MessageAdapter.MessageAdapter> Messages { get; } = new List<MessageAdapter.MessageAdapter>();
    public void ReceiveMessage(Message message)
    {
        Messages.Add(new MessageAdapter.MessageAdapter(message));
    }
}