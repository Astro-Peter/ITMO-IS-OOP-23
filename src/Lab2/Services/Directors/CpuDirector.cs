using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class CpuDirector : IBaseDirector<ICpuBuilder>
{
    private readonly Cpu _cpu;

    public CpuDirector(Cpu cpu)
    {
        _cpu = cpu;
    }

    public ICpuBuilder Direct(ICpuBuilder baseBuilder)
    {
        baseBuilder.SetName(_cpu.Name)
            .SetSocket(_cpu.Socket)
            .SetFrequency(_cpu.Frequency)
            .SetTdp(_cpu.Tdp)
            .SetPower(_cpu.PowerConsumption)
            .SetCoreNumber(_cpu.CoreNumber)
            .SetMaxRamFrequency(_cpu.MaxRamFrequency)
            .SetBuiltInGpu(_cpu.BuiltInGpu);
        return baseBuilder;
    }
}