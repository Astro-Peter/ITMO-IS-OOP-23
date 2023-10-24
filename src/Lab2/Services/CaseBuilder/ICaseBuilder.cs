using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CaseBuilder;

public interface ICaseBuilder : IBaseBuilder<PcCase>,
    ISetDimensions<ICaseBuilder>,
    ISetMaximumGpuDimensions<ICaseBuilder>,
    ISetMotherboardFormFactor<ICaseBuilder>,
    ISetName<ICaseBuilder>
{
}