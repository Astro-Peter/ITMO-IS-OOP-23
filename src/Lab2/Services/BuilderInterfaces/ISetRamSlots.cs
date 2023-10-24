namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetRamSlots<out T>
{
    public T SetRamSlots(int ramSlots);
}