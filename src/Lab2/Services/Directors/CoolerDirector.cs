using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CoolerBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class CoolerDirector : IBaseDirector<CoolingSystem, ICoolerBuilder>
{
    public CoolerDirector(ICoolerBuilder builder)
    {
        Builder = builder;
    }

    public ICoolerBuilder Builder { get; private set; }

    public void BuildWith(ICoolerBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(CoolingSystem baseComponent)
    {
        Builder.SetName(baseComponent.Name)
            .SetTdp(baseComponent.Tdp)
            .SetDimensions(baseComponent.Dimensions)
            .SetCompatibleSockets(baseComponent.CompatibleSockets);
    }

    public CoolingSystem GetComponent()
    {
        return Builder.Build();
    }
}