namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetSocket<out T>
{
    public T SetSocket(string socket);
}