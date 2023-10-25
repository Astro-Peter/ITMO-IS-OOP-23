using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

public class CpuBuilder : ICpuBuilder
{
    private string? Name { get; set; }
    private double? Frequency { get; set; }
    private int? CoreNumber { get; set; }
    private string? Socket { get; set; }
    private Gpu? Gpu { get; set; }
    private double? MaxRamFrequency { get; set; }
    private int? Tdp { get; set; }
    private int? Power { get; set; }
    public Cpu Build()
    {
        return new Cpu(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            Frequency ?? throw new UndefinedParameterException(nameof(Frequency)),
            CoreNumber ?? throw new UndefinedParameterException(nameof(CoreNumber)),
            Socket ?? throw new UndefinedParameterException(nameof(Socket)),
            Gpu,
            MaxRamFrequency ?? throw new UndefinedParameterException(nameof(MaxRamFrequency)),
            Tdp ?? throw new UndefinedParameterException(nameof(Tdp)),
            Power ?? throw new UndefinedParameterException(nameof(Power)));
    }

    public ICpuBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public ICpuBuilder SetFrequency(double frequency)
    {
        Frequency = frequency;
        return this;
    }

    public ICpuBuilder SetCoreNumber(int coreNumber)
    {
        CoreNumber = coreNumber;
        return this;
    }

    public ICpuBuilder SetSocket(string socket)
    {
        Socket = socket;
        return this;
    }

    public ICpuBuilder SetBuiltInGpu(Gpu? gpu)
    {
        Gpu = gpu;
        return this;
    }

    public ICpuBuilder SetMaxRamFrequency(double maxRamFrequency)
    {
        MaxRamFrequency = maxRamFrequency;
        return this;
    }

    public ICpuBuilder SetTdp(int tdp)
    {
        Tdp = tdp;
        return this;
    }

    public ICpuBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }
}