using System.Drawing;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriver;

public class FileDisplayDriver : IDisplayDriver
{
    private readonly StreamWriter _displayFile;
    private Color _color;

    public FileDisplayDriver(Color color, string fileName)
    {
        _color = color;
        _displayFile = File.AppendText(fileName);
    }

    public void Clear()
    {
        _displayFile.Flush();
    }

    public void SetColor(Color color)
    {
        _color = color;
    }

    public void Write(string message)
    {
        _displayFile.Write(Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(message));
    }
}