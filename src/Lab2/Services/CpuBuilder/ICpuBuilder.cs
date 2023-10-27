using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

public interface ICpuBuilder : IBaseBuilder<Cpu>
{
    public ICpuBuilder SetName(string name);
    public ICpuBuilder SetFrequency(double frequency);
    public ICpuBuilder SetCoreNumber(int coreNumber);
    public ICpuBuilder SetSocket(string socket);
    public ICpuBuilder SetBuiltInGpu(BuiltInGpu? gpu);
    public ICpuBuilder SetMaxRamFrequency(double maxRamFrequency);
    public ICpuBuilder SetTdp(int tdp);
    public ICpuBuilder SetPower(int powerUsage);
}