using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

public interface IPowerSupplyBuilder : IBaseBuilder<PowerSupply>,
    ISetPower<IPowerSupplyBuilder>,
    ISetName<IPowerSupplyBuilder>
{
}