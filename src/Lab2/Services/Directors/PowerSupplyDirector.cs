using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class PowerSupplyDirector : IBaseDirector<IPowerSupplyBuilder>
{
    private readonly PowerSupply _powerSupply;

    public PowerSupplyDirector(PowerSupply powerSupply)
    {
        _powerSupply = powerSupply;
    }

    public IPowerSupplyBuilder Direct(IPowerSupplyBuilder baseBuilder)
    {
        baseBuilder.SetName(_powerSupply.Name)
            .SetPower(_powerSupply.Power);
        return baseBuilder;
    }
}