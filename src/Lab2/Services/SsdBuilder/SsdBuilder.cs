using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.SsdBuilder;

public class SsdBuilder : ISsdBuilder
{
    private string? Name { get; set; }
    private string? ConnectionType { get; set; }
    private int? MemoryCapacity { get; set; }
    private int? Speed { get; set; }
    private int? Power { get; set; }
    public Ssd Build()
    {
        return new Ssd(
            ConnectionType ?? throw new UndefinedParameterException(nameof(ConnectionType)),
            MemoryCapacity ?? throw new UndefinedParameterException(nameof(MemoryCapacity)),
            Speed ?? throw new UndefinedParameterException(nameof(Speed)),
            Power ?? throw new UndefinedParameterException(nameof(Power)),
            Name ?? throw new UndefinedParameterException(nameof(Name)));
    }

    public ISsdBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public ISsdBuilder SetConnectionType(string connectionType)
    {
        ConnectionType = connectionType;
        return this;
    }

    public ISsdBuilder SetMemoryCapacity(int memoryCapacity)
    {
        MemoryCapacity = memoryCapacity;
        return this;
    }

    public ISsdBuilder SetSpeed(int speed)
    {
        Speed = speed;
        return this;
    }

    public ISsdBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }
}