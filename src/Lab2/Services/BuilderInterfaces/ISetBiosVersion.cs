namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetBiosVersion<out T>
{
    public T SetBiosVersion(string biosVersion);
}