namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetFrequency<out T>
{
    public T SetFrequency(double frequency);
}