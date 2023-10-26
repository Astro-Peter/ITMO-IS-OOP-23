using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PowerSupplyBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class PowerSupplyDirector : IBaseDirector<PowerSupply, IPowerSupplyBuilder>
{
    public PowerSupplyDirector(IPowerSupplyBuilder builder)
    {
        Builder = builder;
    }

    public IPowerSupplyBuilder Builder { get; private set; }

    public void BuildWith(IPowerSupplyBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(PowerSupply baseComponent)
    {
        Builder.SetName(baseComponent.Name)
            .SetPower(baseComponent.Power);
    }

    public PowerSupply GetComponent()
    {
        return Builder.Build();
    }
}