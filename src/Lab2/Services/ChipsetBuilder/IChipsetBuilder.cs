using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;

public interface IChipsetBuilder : IBaseBuilder<Chipset>,
    ISetAvailableMemoryFrequencies<IChipsetBuilder>,
    ISetXmpSupport<IChipsetBuilder>,
    ISetName<IChipsetBuilder>
{
}