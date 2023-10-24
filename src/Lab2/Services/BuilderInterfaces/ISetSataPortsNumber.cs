namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetSataPortsNumber<out T>
{
    public T SetSataPortsNumber(int portsNumber);
}