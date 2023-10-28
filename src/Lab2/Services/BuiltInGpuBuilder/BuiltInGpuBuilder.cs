using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuiltInGpuBuilder;

public class BuiltInGpuBuilder : IBuiltInGpuBuilder
{
    private double _frequency;
    private string _name = "empty";

    public BuiltInGpu Build()
    {
        return new BuiltInGpu(
            _name,
            _frequency);
    }

    public IBuiltInGpuBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IBuiltInGpuBuilder SetFrequency(double frequency)
    {
        _frequency = frequency;
        return this;
    }
}