using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class CpuDirector : IBaseDirector<Cpu, ICpuBuilder>
{
    public CpuDirector(ICpuBuilder builder)
    {
        Builder = builder;
    }

    public ICpuBuilder Builder { get; private set; }

    public void BuildWith(ICpuBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Cpu baseComponent)
    {
        Builder.SetName(baseComponent.Name)
            .SetSocket(baseComponent.Socket)
            .SetFrequency(baseComponent.Frequency)
            .SetTdp(baseComponent.Tdp)
            .SetPower(baseComponent.PowerConsumption)
            .SetCoreNumber(baseComponent.CoreNumber)
            .SetMaxRamFrequency(baseComponent.MaxRamFrequency)
            .SetBuiltInGpu(baseComponent.BuiltInGpu);
    }

    public Cpu GetComponent()
    {
        return Builder.Build();
    }
}