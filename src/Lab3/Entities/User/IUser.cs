using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.User;

public interface IUser
{
    public IList<MessageAdapter.MessageAdapter> Messages { get; }
    public void ReceiveMessage(Message message);
}