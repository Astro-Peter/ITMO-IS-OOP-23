namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetName<out T>
{
    public T SetName(string name);
}