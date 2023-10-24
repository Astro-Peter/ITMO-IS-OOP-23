namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPciELinesNumber<out T>
{
    public T SetPciELinesNumber(int linesNumber);
}