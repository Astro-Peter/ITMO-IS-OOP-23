namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;

public interface IRequestIterator
{
    public string GetCurrentObject();
    public bool Advance();
}