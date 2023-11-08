using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Tools;

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

    public void SetStatusRead()
    {
        Read = Read ? throw new ReadMessageException() : true;
    }
}