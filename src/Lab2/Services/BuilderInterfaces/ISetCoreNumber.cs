namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetCoreNumber<out T>
{
    public T SetCoreNumber(int coreNumber);
}