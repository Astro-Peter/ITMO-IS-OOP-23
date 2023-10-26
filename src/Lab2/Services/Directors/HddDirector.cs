using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.HddBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class HddDirector : IBaseDirector<Hdd, IHddBuilder>
{
    public HddDirector(IHddBuilder builder)
    {
        Builder = builder;
    }

    public IHddBuilder Builder { get; set; }

    public void BuildWith(IHddBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Hdd baseComponent)
    {
        Builder.SetPower(baseComponent.PowerUsage)
            .SetName(baseComponent.Name)
            .SetMemoryCapacity(baseComponent.Capacity)
            .SetRpm(baseComponent.Rpm);
    }

    public Hdd GetComponent()
    {
        return Builder.Build();
    }
}