using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.HddBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class HddDirector : IBaseDirector<IHddBuilder>
{
    private readonly Hdd _baseHdd;

    public HddDirector(Hdd hdd)
    {
        _baseHdd = hdd;
    }

    public IHddBuilder Direct(IHddBuilder baseBuilder)
    {
        baseBuilder.SetPower(_baseHdd.PowerUsage)
            .SetName(_baseHdd.Name)
            .SetMemoryCapacity(_baseHdd.Capacity)
            .SetRpm(_baseHdd.Rpm);
        return baseBuilder;
    }
}