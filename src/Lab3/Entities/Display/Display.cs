using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriver;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;

public class Display : IDisplay
{
    private readonly IDisplayDriver _displayDriver;

    public Display(IDisplayDriver driver)
    {
        _displayDriver = driver;
    }

    public void ShowMessage(string message)
    {
        _displayDriver.Clear();
        _displayDriver.Write(message);
    }

    public void SetColor(Color color)
    {
        _displayDriver.SetColor(color);
    }
}