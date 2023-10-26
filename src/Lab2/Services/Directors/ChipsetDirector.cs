using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class ChipsetDirector : IBaseDirector<Chipset, IChipsetBuilder>
{
    public ChipsetDirector(IChipsetBuilder builder)
    {
        Builder = builder;
    }

    public IChipsetBuilder Builder { get; private set; }

    public void BuildWith(IChipsetBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Chipset baseComponent)
    {
        Builder.SetName(baseComponent.Name)
            .SetXmpSupport(baseComponent.XmpSupport)
            .SetAvailableMemoryFrequencies(baseComponent.AvailableMemoryFrequencies);
    }

    public Chipset GetComponent()
    {
        return Builder.Build();
    }
}