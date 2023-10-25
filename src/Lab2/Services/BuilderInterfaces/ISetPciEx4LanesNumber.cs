namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPciEx4LanesNumber<out T>
{
    public T SetPciEx4LanesNumber(int lanesNumber);
}