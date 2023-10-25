namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPciEx1LanesNumber<out T>
{
    public T SetPciEx1LanesNumber(int lanesNumber);
}