using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetPcCase<out T>
{
    public T SetPcCase(PcCase pcCase);
}