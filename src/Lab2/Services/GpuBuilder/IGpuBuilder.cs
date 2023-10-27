using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.GpuBuilder;

public interface IGpuBuilder : IBaseBuilder<Gpu>
{
    public IGpuBuilder SetName(string name);
    public IGpuBuilder SetMemoryCapacity(int memoryCapacity);
    public IGpuBuilder SetPciEVersion(string pciEVersion);
    public IGpuBuilder SetFrequency(double frequency);
    public IGpuBuilder SetPower(int powerUsage);
    public IGpuBuilder SetDimensions(Dimensions dimensions);
}