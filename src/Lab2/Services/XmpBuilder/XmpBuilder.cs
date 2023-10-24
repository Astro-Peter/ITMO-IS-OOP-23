using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

public class XmpBuilder : IXmpBuilder
{
    private string? Name { get; set; }
    private double? Frequency { get; set; }
    private double? Voltage { get; set; }
    private string? Timings { get; set; }
    public XmpProfile Build()
    {
        return new XmpProfile(
            Voltage ?? throw new UndefinedParameterException(nameof(Voltage)),
            Frequency ?? throw new UndefinedParameterException(nameof(Frequency)),
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            Timings ?? throw new UndefinedParameterException(nameof(Timings)));
    }

    public IXmpBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IXmpBuilder SetFrequency(double frequency)
    {
        Frequency = frequency;
        return this;
    }

    public IXmpBuilder SetVoltage(double voltage)
    {
        Voltage = voltage;
        return this;
    }

    public IXmpBuilder SetTimings(string timings)
    {
        Timings = timings;
        return this;
    }
}