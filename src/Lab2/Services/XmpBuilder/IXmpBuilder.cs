using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

public interface IXmpBuilder : IBaseBuilder<XmpProfile>
{
    public IXmpBuilder SetName(string name);
    public IXmpBuilder SetFrequency(double frequency);
    public IXmpBuilder SetVoltage(double voltage);
    public IXmpBuilder SetTimings(string timings);
}