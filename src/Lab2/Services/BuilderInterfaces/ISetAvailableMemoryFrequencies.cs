using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetAvailableMemoryFrequencies<out T>
{
    public T SetAvailableMemoryFrequencies(IList<double> memoryFrequencies);
}