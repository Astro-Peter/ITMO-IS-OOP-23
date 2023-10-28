using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class GpuDirector : IBaseDirector<IGpuBuilder>
{
    private Gpu _gpu;
    public GpuDirector(Gpu gpu)
    {
        _gpu = gpu;
    }

    public IGpuBuilder Direct(IGpuBuilder baseBuilder)
    {
        baseBuilder.SetFrequency(this._gpu.Frequency)
            .SetName(this._gpu.Name)
            .SetPower(this._gpu.PowerUsage)
            .SetDimensions(this._gpu.Dimensions)
            .SetMemoryCapacity(this._gpu.MemoryCapacity)
            .SetPciEVersion(this._gpu.PciEVersion);
        return baseBuilder;
    }
}