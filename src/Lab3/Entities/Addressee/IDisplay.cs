using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public interface IDisplay : IAddressee
{
    void SetColor(Color color);
}