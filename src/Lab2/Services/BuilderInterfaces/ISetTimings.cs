namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetTimings<out T>
{
    public T SetTimings(string timings);
}