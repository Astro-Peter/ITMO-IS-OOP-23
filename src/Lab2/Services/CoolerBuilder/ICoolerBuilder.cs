using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CoolerBuilder;

public interface ICoolerBuilder : IBaseBuilder<CoolingSystem>,
    ISetName<ICoolerBuilder>,
    ISetDimensions<ICoolerBuilder>,
    ISetCompatibleSockets<ICoolerBuilder>,
    ISetTdp<ICoolerBuilder>
{
}