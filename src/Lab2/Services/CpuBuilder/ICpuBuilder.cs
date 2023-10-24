using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

public interface ICpuBuilder : IBaseBuilder<Cpu>,
    ISetName<ICpuBuilder>,
    ISetFrequency<ICpuBuilder>,
    ISetCoreNumber<ICpuBuilder>,
    ISetSocket<ICpuBuilder>,
    ISetBuiltInGpu<ICpuBuilder>,
    ISetMaxRamFrequency<ICpuBuilder>,
    ISetTdp<ICpuBuilder>,
    ISetPower<ICpuBuilder>
{
}