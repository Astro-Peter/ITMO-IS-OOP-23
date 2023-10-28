using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

public class XmpBuilder : IXmpBuilder
{
    private double _frequency;
    private string _name = "none";
    private string _timings = "none";
    private double _voltage;

    public XmpProfile Build()
    {
        return new XmpProfile(
            _voltage,
            _frequency,
            _name,
            _timings);
    }

    public IXmpBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IXmpBuilder SetFrequency(double frequency)
    {
        _frequency = frequency;
        return this;
    }

    public IXmpBuilder SetVoltage(double voltage)
    {
        _voltage = voltage;
        return this;
    }

    public IXmpBuilder SetTimings(string timings)
    {
        _timings = timings;
        return this;
    }
}