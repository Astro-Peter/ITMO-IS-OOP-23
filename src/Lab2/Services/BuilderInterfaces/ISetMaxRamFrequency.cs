namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetMaxRamFrequency<out T>
{
    public T SetMaxRamFrequency(double maxRamFrequency);
}