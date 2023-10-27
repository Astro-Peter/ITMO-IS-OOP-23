using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

public interface IPowerSupplyBuilder : IBaseBuilder<PowerSupply>
{
    public IPowerSupplyBuilder SetPower(int powerUsage);
    public IPowerSupplyBuilder SetName(string name);
}