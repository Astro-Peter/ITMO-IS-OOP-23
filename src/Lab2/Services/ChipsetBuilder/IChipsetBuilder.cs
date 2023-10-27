using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;

public interface IChipsetBuilder : IBaseBuilder<Chipset>
{
    public IChipsetBuilder SetAvailableMemoryFrequencies(IList<double> memoryFrequencies);
    public IChipsetBuilder SetXmpSupport(bool support);
    public IChipsetBuilder SetName(string name);
}