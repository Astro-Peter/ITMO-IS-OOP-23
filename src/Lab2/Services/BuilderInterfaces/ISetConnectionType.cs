namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetConnectionType<out T>
{
    public T SetConnectionType(string connectionType);
}