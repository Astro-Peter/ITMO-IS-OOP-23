using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriver;

public interface IDisplayDriver
{
    public void Clear();
    public void SetColor(Color color);
    public void Write(string message);
}