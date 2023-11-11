using Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class DisplayAddressee : IAddressee
{
    private readonly IDisplay _display;
    public DisplayAddressee(IDisplay display)
    {
        _display = display;
    }

    public void ReceiveMessage(Message message)
    {
        _display.ShowMessage(message.ToString());
    }
}