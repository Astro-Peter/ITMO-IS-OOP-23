using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class RamDirector : IBaseDirector<RandomAccessMemory, IRamBuilder>
{
    public RamDirector(IRamBuilder builder)
    {
        Builder = builder;
    }

    public IRamBuilder Builder { get; private set; }

    public void BuildWith(IRamBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(RandomAccessMemory baseComponent)
    {
        Builder.SetJedec(baseComponent.Jedec)
            .SetName(baseComponent.Name)
            .SetPower(baseComponent.PowerUsage)
            .SetDdrVersion(baseComponent.DdrVersion)
            .SetMemoryCapacity(baseComponent.MemoryAmount)
            .SetXmpProfiles(baseComponent.AvailableProfiles)
            .SetRamFormFactor(baseComponent.RamFormFactor);
    }

    public RandomAccessMemory GetComponent()
    {
        return Builder.Build();
    }
}