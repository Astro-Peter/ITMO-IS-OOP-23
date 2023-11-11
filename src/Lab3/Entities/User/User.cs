using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.User;

public class User : IUser
{
    private readonly List<MessageAdapter.MessageAdapter> _messages = new();

    public IReadOnlyCollection<MessageAdapter.MessageAdapter> Messages => _messages;

    public void ReceiveMessage(Message message)
    {
        _messages.Add(new MessageAdapter.MessageAdapter(message));
    }
}