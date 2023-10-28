using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

public class CpuBuilder : ICpuBuilder
{
    private int _coreNumber;
    private double _frequency;
    private BuiltInGpu? _gpu;
    private double _maxRamFrequency;
    private string _name = "empty";
    private int _power;
    private string _socket = "none";
    private int _tdp;

    public Cpu Build()
    {
        return new Cpu(
            _name,
            _frequency,
            _coreNumber,
            _socket,
            _gpu,
            _maxRamFrequency,
            _tdp,
            _power);
    }

    public ICpuBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public ICpuBuilder SetFrequency(double frequency)
    {
        _frequency = frequency;
        return this;
    }

    public ICpuBuilder SetCoreNumber(int coreNumber)
    {
        _coreNumber = coreNumber;
        return this;
    }

    public ICpuBuilder SetSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public ICpuBuilder SetBuiltInGpu(BuiltInGpu? gpu)
    {
        _gpu = gpu;
        return this;
    }

    public ICpuBuilder SetMaxRamFrequency(double maxRamFrequency)
    {
        _maxRamFrequency = maxRamFrequency;
        return this;
    }

    public ICpuBuilder SetTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public ICpuBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }
}