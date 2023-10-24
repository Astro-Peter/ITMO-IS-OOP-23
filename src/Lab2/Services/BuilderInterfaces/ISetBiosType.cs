namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetBiosType<out T>
{
    public T SetBiosType(string biosType);
}