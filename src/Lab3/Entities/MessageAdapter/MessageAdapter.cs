using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageAdapter;

public class MessageAdapter : IMessageAdapter
{
    public MessageAdapter(Message message)
    {
        Message = message;
        Read = false;
    }

    private bool Read { get; set; }

    private Message Message { get; }

    public Message GetContents() => Message;
    public bool GetIsRead() => Read;

    public MessageStatusChange SetStatusRead()
    {
        if (Read)
        {
            return new MessageStatusChange(false, "Message was already read");
        }

        Read = true;
        return new MessageStatusChange(true);
    }
}