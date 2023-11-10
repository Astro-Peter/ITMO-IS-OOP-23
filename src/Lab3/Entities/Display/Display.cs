using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriver;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;

public class Display : IDisplay
{
    private IDisplayDriver _displayDriver;

    public Display(IDisplayDriver driver)
    {
        _displayDriver = driver;
    }

    public void ShowMessage(Message message)
    {
        _displayDriver.Clear();
        string output = message.Header + '\n' + message.Body;
        _displayDriver.Write(output);
    }

    public void SetColor(Color color)
    {
        _displayDriver.SetColor(color);
    }
}