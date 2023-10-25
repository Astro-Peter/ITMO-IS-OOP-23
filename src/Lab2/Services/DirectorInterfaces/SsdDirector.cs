using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.SsdBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class SsdDirector : IBaseDirector<Ssd, ISsdBuilder>
{
    public SsdDirector(ISsdBuilder builder)
    {
        Builder = builder;
    }

    public ISsdBuilder Builder { get; private set; }

    public void BuildWith(ISsdBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Ssd baseComponent)
    {
        Builder.SetName(baseComponent.Name)
            .SetPower(baseComponent.PowerUsage)
            .SetMemoryCapacity(baseComponent.Capacity)
            .SetSpeed(baseComponent.Speed)
            .SetConnectionType(baseComponent.ConnectionType);
    }

    public Ssd GetComponent()
    {
        return Builder.Build();
    }
}