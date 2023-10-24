namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetRamFormFactor<out T>
{
    public T SetRamFormFactor(string ramFormFactor);
}