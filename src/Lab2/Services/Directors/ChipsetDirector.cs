using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class ChipsetDirector : IBaseDirector<IChipsetBuilder>
{
    private readonly Chipset _chipset;

    public ChipsetDirector(Chipset chipset)
    {
        _chipset = chipset;
    }

    public IChipsetBuilder Direct(IChipsetBuilder baseBuilder)
    {
        baseBuilder.SetName(_chipset.Name)
            .SetXmpSupport(_chipset.XmpSupport)
            .SetAvailableMemoryFrequencies(_chipset.AvailableMemoryFrequencies);
        return baseBuilder;
    }
}