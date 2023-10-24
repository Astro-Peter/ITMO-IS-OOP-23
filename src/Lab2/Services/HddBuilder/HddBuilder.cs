using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.HddBuilder;

public class HddBuilder : IHddBuilder
{
    private int? MemoryCapacity { get; set; }
    private int? Power { get; set; }
    private string? Name { get; set; }
    private int? Rpm { get; set; }

    public Hdd Build()
    {
        return new Hdd(
            MemoryCapacity ?? throw new UndefinedParameterException(nameof(MemoryCapacity)),
            Rpm ?? throw new UndefinedParameterException(nameof(Rpm)),
            Power ?? throw new UndefinedParameterException(nameof(Power)),
            Name ?? throw new UndefinedParameterException(nameof(Name)));
    }

    public IHddBuilder SetMemoryCapacity(int memoryCapacity)
    {
        MemoryCapacity = memoryCapacity;
        return this;
    }

    public IHddBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }

    public IHddBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IHddBuilder SetRpm(int rpm)
    {
        Rpm = rpm;
        return this;
    }
}