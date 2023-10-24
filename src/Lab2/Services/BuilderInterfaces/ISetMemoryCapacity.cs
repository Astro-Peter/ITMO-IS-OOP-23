namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetMemoryCapacity<out T>
{
    public T SetMemoryCapacity(int memoryCapacity);
}