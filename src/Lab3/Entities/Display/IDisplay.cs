using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Display;

public interface IDisplay
{
    public void ShowMessage(string message);
    public void SetColor(Color color);
}