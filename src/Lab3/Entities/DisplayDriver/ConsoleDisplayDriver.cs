using System;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriver;

public class ConsoleDisplayDriver : IDisplayDriver
{
    private Color _color;

    public ConsoleDisplayDriver(Color color)
    {
        _color = color;
    }

    public void Clear()
    {
        Console.Clear();
    }

    public void SetColor(Color color)
    {
        _color = color;
    }

    public void Write(string message)
    {
        Console.Out.WriteLine(Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(message));
    }
}