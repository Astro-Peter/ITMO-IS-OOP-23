namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPower<out T>
{
    public T SetPower(int powerUsage);
}