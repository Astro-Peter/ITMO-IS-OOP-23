namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetRpm<out T>
{
    public T SetRpm(int rpm);
}