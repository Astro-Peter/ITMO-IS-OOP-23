using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuiltInGpuBuilder;

public class BuiltInGpuBuilder : IBuiltInGpuBuilder
{
    private string? Name { get; set; }
    private double? Frequency { get; set; }
    public BuiltInGpu Build()
    {
        return new BuiltInGpu(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            Frequency ?? throw new UndefinedParameterException(nameof(Frequency)));
    }

    public IBuiltInGpuBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IBuiltInGpuBuilder SetFrequency(double frequency)
    {
        Frequency = frequency;
        return this;
    }
}