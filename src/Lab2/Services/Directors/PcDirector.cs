using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class PcDirector : IBaseDirector<IPcBuilder>
{
    private PersonalComputerParts _pc;
    public PcDirector(PersonalComputerParts pc)
    {
        _pc = pc;
    }

    public IPcBuilder Direct(IPcBuilder baseBuilder)
    {
        baseBuilder.SetHdds(_pc.Hdds)
            .SetCpu(_pc.Cpu)
            .SetGpu(_pc.Gpu)
            .SetRam(_pc.Ram)
            .SetSsds(_pc.Ssds)
            .SetCoolingSystem(_pc.CoolingSystem)
            .SetMotherBoard(_pc.Motherboard)
            .SetPcCase(_pc.PcCase)
            .SetPowerSupply(_pc.PowerSupply)
            .SetWifiAdapter(_pc.WifiAdapter);
        return baseBuilder;
    }
}