using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetMaximumGpuDimensions<out T>
{
    public T SetMaximumGpuDimensions(Dimensions dimensions);
}