using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

public class XmpBuilder : IXmpBuilder
{
    private string _name = "none";
    private double _frequency;
    private double _voltage;
    private string _timings = "none";
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