namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPciEVersion<out T>
{
    public T SetPciEVersion(string pciEVersion);
}