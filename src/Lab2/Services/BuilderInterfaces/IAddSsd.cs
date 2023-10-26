using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface IAddSsd<out T>
{
    public T AddSsd(Ssd ssd);
}