namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetVoltage<out T>
{
    public T SetVoltage(double voltage);
}