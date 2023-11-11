using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class MessengerAddressee : IAddressee
{
    private readonly IMessenger _messenger;
    public MessengerAddressee(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void ReceiveMessage(Message message)
    {
        _messenger.ShowMessage(message.ToString());
    }
}