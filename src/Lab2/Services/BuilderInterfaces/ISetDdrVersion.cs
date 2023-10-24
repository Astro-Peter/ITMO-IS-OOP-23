namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetDdrVersion<out T>
{
    public T SetDdrVersion(string ddrVersion);
}