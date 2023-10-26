using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetCpu<out T>
{
    public T SetCpu(Cpu cpu);
}