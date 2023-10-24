namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetJedec<out T>
{
    public T SetJedec(string jedec);
}