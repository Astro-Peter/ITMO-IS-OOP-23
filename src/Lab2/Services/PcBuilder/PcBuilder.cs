using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;

public class PcBuilder : IPcBuilder
{
    private WifiAdapter? WifiAdapter { get; set; }
    private PowerSupply? PowerSupply { get; set; }
    private IList<RandomAccessMemory>? Ram { get; set; }
    private PcCase? PcCase { get; set; }
    private CoolingSystem? CoolingSystem { get; set; }
    private IList<Ssd>? Ssds { get; set; }
    private IList<Hdd>? Hdds { get; set; }
    private Gpu? Gpu { get; set; }
    private Cpu? Cpu { get; set; }
    private Motherboard? Motherboard { get; set; }

    public IPcBuilder SetMotherBoard(Motherboard motherboard)
    {
        Motherboard = motherboard;
        return this;
    }

    public IPcBuilder SetCpu(Cpu cpu)
    {
        Cpu = cpu;
        return this;
    }

    public IPcBuilder SetGpu(Gpu? gpu)
    {
        Gpu = gpu;
        return this;
    }

    public IPcBuilder SetHdds(IList<Hdd>? hdds)
    {
        Hdds = hdds;
        return this;
    }

    public IPcBuilder SetSsds(IList<Ssd>? ssds)
    {
        Ssds = ssds;
        return this;
    }

    public IPcBuilder SetCoolingSystem(CoolingSystem coolingSystem)
    {
        CoolingSystem = coolingSystem;
        return this;
    }

    public IPcBuilder SetPcCase(PcCase pcCase)
    {
        PcCase = pcCase;
        return this;
    }

    public IPcBuilder SetRam(IList<RandomAccessMemory> ram)
    {
        Ram = ram;
        return this;
    }

    public IPcBuilder SetPowerSupply(PowerSupply powerSupply)
    {
        PowerSupply = powerSupply;
        return this;
    }

    public IPcBuilder SetWifiAdapter(WifiAdapter? wifiAdapter)
    {
        WifiAdapter = wifiAdapter;
        return this;
    }

    public IPcBuilder AddHdd(Hdd hdd)
    {
        Hdds ??= new List<Hdd>();

        Hdds.Add(hdd);
        return this;
    }

    public IPcBuilder AddSsd(Ssd ssd)
    {
        Ssds ??= new List<Ssd>();

        Ssds.Add(ssd);
        return this;
    }

    public IPcBuilder AddRamStick(RandomAccessMemory ram)
    {
        Ram ??= new List<RandomAccessMemory>();

        Ram.Add(ram);
        return this;
    }

    public PersonalComputerParts Build()
    {
        return new PersonalComputerParts(
            Motherboard ?? throw new UndefinedParameterException(nameof(Motherboard)),
            Cpu ?? throw new UndefinedParameterException(nameof(Cpu)),
            Gpu,
            Hdds,
            Ssds,
            CoolingSystem ?? throw new UndefinedParameterException(nameof(CoolingSystem)),
            PcCase ?? throw new UndefinedParameterException(nameof(PcCase)),
            Ram ?? throw new UndefinedParameterException(nameof(Ram)),
            PowerSupply ?? throw new UndefinedParameterException(nameof(PowerSupply)),
            WifiAdapter);
    }
}