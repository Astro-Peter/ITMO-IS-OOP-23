using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

public class GpuBuilder : IGpuBuilder
{
    private string? Name { get; set; }
    private int? MemoryCapacity { get; set; }
    private string? PciEVersion { get; set; }
    private double? Frequency { get; set; }
    private int? Power { get; set; }
    private Dimensions? Dimensions { get; set; }
    public Gpu Build()
    {
        return new Gpu(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            Dimensions ?? throw new UndefinedParameterException(nameof(Dimensions)),
            MemoryCapacity ?? throw new UndefinedParameterException(nameof(MemoryCapacity)),
            PciEVersion ?? throw new UndefinedParameterException(nameof(PciEVersion)),
            Frequency ?? throw new UndefinedParameterException(nameof(Frequency)),
            Power ?? throw new UndefinedParameterException(nameof(Power)));
    }

    public IGpuBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IGpuBuilder SetMemoryCapacity(int memoryCapacity)
    {
        MemoryCapacity = memoryCapacity;
        return this;
    }

    public IGpuBuilder SetPciEVersion(string pciEVersion)
    {
        PciEVersion = pciEVersion;
        return this;
    }

    public IGpuBuilder SetFrequency(double frequency)
    {
        Frequency = frequency;
        return this;
    }

    public IGpuBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }

    public IGpuBuilder SetDimensions(Dimensions dimensions)
    {
        Dimensions = dimensions;
        return this;
    }
}