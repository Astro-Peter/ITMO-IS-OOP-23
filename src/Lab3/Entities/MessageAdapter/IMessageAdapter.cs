using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.MessageAdapter;

public interface IMessageAdapter
{
    public Message GetContents();
    public bool GetIsRead();
    public MessageStatusChange SetStatusRead();
}