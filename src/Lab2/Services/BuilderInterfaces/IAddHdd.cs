using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface IAddHdd<out T>
{
    public T AddHdd(Hdd hdd);
}