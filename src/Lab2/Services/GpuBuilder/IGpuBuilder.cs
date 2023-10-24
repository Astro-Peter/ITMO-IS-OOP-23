using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

public interface IGpuBuilder : IBaseBuilder<Gpu>,
    ISetName<IGpuBuilder>,
    ISetMemoryCapacity<IGpuBuilder>,
    ISetPciEVersion<IGpuBuilder>,
    ISetFrequency<IGpuBuilder>,
    ISetPower<IGpuBuilder>,
    ISetDimensions<IGpuBuilder>
{
}