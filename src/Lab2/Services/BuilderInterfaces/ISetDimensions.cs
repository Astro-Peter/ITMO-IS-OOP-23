using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetDimensions<out T>
{
    public T SetDimensions(Dimensions dimensions);
}