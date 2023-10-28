using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

public class PowerSupplyBuilder : IPowerSupplyBuilder
{
    private string _name = "none";
    private int _power = -100;

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