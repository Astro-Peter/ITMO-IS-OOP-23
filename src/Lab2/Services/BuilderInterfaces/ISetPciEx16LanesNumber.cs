namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPciEx16LanesNumber<out T>
{
    public T SetPciEx16LanesNumber(int lanesNumber);
}