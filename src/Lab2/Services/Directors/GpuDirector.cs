using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class GpuDirector : IBaseDirector<IGpuBuilder>
{
    private readonly Gpu _gpu;

    public GpuDirector(Gpu gpu)
    {
        _gpu = gpu;
    }

    public IGpuBuilder Direct(IGpuBuilder baseBuilder)
    {
        baseBuilder.SetFrequency(_gpu.Frequency)
            .SetName(_gpu.Name)
            .SetPower(_gpu.PowerUsage)
            .SetDimensions(_gpu.Dimensions)
            .SetMemoryCapacity(_gpu.MemoryCapacity)
            .SetPciEVersion(_gpu.PciEVersion);
        return baseBuilder;
    }
}