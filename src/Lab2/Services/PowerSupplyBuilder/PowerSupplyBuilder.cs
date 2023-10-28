using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

public class PowerSupplyBuilder : IPowerSupplyBuilder
{
    private int _power = -100;
    private string _name = "none";

    public PowerSupply Build()
    {
        return new PowerSupply(
            _power,
            _name);
    }

    public IPowerSupplyBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }

    public IPowerSupplyBuilder SetName(string name)
    {
        _name = name;
        return this;
    }
}