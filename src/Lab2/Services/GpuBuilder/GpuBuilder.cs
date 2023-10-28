using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

public class GpuBuilder : IGpuBuilder
{
    private Dimensions _dimensions = new(0, 0, 0);
    private double _frequency;
    private int _memoryCapacity;
    private string _name = "none";
    private string _pciEVersion = "none";
    private int _power;

    public Gpu Build()
    {
        return new Gpu(
            _name,
            _dimensions,
            _memoryCapacity,
            _pciEVersion,
            _frequency,
            _power);
    }

    public IGpuBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IGpuBuilder SetMemoryCapacity(int memoryCapacity)
    {
        _memoryCapacity = memoryCapacity;
        return this;
    }

    public IGpuBuilder SetPciEVersion(string pciEVersion)
    {
        _pciEVersion = pciEVersion;
        return this;
    }

    public IGpuBuilder SetFrequency(double frequency)
    {
        _frequency = frequency;
        return this;
    }

    public IGpuBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }

    public IGpuBuilder SetDimensions(Dimensions dimensions)
    {
        _dimensions = dimensions;
        return this;
    }
}