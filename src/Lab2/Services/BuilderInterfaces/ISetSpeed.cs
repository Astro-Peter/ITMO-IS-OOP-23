namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetSpeed<out T>
{
    public T SetSpeed(int speed);
}