using Itmo.ObjectOrientedProgramming.Lab3.Entities.Printer;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

public class Messenger : IMessenger
{
    private readonly IPrinter _printer;

    public Messenger(IPrinter printer)
    {
        _printer = printer;
    }

    public void ShowMessage(string message)
    {
        _printer.ShowMessage("Messenger:\n" + message);
    }
}