using System;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

public class PowerSupplyBuilder : IPowerSupplyBuilder
{
    private int? Power { get; set; }
    private string? Name { get; set; }

    public PowerSupply Build()
    {
        return new PowerSupply(
            Power ?? throw new UndefinedParameterException(nameof(Power)),
            Name ?? throw new UndefinedParameterException(nameof(Name)));
    }

    public IPowerSupplyBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }

    public IPowerSupplyBuilder SetName(string name)
    {
        Name = name;
        return this;
    }
}