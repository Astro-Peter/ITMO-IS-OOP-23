using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class GpuDirector : IBaseDirector<Gpu, IGpuBuilder>
{
    public GpuDirector(IGpuBuilder builder)
    {
        Builder = builder;
    }

    public IGpuBuilder Builder { get; private set; }

    public void BuildWith(IGpuBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Gpu baseComponent)
    {
        Builder.SetFrequency(baseComponent.Frequency)
            .SetName(baseComponent.Name)
            .SetPower(baseComponent.PowerUsage)
            .SetDimensions(baseComponent.Dimensions)
            .SetMemoryCapacity(baseComponent.MemoryCapacity)
            .SetPciEVersion(baseComponent.PciEVersion);
    }

    public Gpu GetComponent()
    {
        return Builder.Build();
    }
}