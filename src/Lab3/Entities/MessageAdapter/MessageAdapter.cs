using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageAdapter;

public class MessageAdapter
{
    public MessageAdapter(Message message)
    {
        Message = message;
        Read = false;
    }

    public bool Read { get; private set; }

    public Message Message { get; }

    public MessageStatusChange SetStatusRead()
    {
        if (Read)
        {
            return new MessageStatusChange.Failure("Message was already read");
        }

        Read = true;
        return new MessageStatusChange.Success();
    }
}