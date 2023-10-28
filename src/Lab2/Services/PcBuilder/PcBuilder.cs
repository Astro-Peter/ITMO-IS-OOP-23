using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.MotherboardBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;

public class PcBuilder : IPcBuilder
{
    private WifiAdapter? _wifiAdapter;
    private PowerSupply _powerSupply = new PowerSupplyBuilder.PowerSupplyBuilder().Build();
    private IList<RandomAccessMemory> _ram = new List<RandomAccessMemory>();
    private PcCase _pcCase = new CaseBuilder.CaseBuilder().Build();
    private CoolingSystem _coolingSystem = new CoolerBuilder.CoolerBuilder().Build();
    private IList<Ssd>? _ssds;
    private IList<Hdd>? _hdds;
    private Gpu? _gpu;
    private Cpu _cpu = new CpuBuilder.CpuBuilder().Build();
    private Motherboard _motherboard = new MotherBoardBuilder().Build();
    private IValidator _validator = new Validator();
    public IPcBuilder WithValidator(IValidator validator)
    {
        _validator = validator;
        return this;
    }

    public IPcBuilder SetMotherBoard(Motherboard motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public IPcBuilder SetCpu(Cpu cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IPcBuilder SetGpu(Gpu? gpu)
    {
        _gpu = gpu;
        return this;
    }

    public IPcBuilder SetHdds(IList<Hdd>? hdds)
    {
        _hdds = hdds;
        return this;
    }

    public IPcBuilder SetSsds(IList<Ssd>? ssds)
    {
        _ssds = ssds;
        return this;
    }

    public IPcBuilder SetCoolingSystem(CoolingSystem coolingSystem)
    {
        _coolingSystem = coolingSystem;
        return this;
    }

    public IPcBuilder SetPcCase(PcCase pcCase)
    {
        _pcCase = pcCase;
        return this;
    }

    public IPcBuilder SetRam(IList<RandomAccessMemory> ram)
    {
        _ram = ram;
        return this;
    }

    public IPcBuilder SetPowerSupply(PowerSupply powerSupply)
    {
        _powerSupply = powerSupply;
        return this;
    }

    public IPcBuilder SetWifiAdapter(WifiAdapter? wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
        return this;
    }

    public IPcBuilder AddHdd(Hdd hdd)
    {
        _hdds ??= new List<Hdd>();

        _hdds.Add(hdd);
        return this;
    }

    public IPcBuilder AddSsd(Ssd ssd)
    {
        _ssds ??= new List<Ssd>();

        _ssds.Add(ssd);
        return this;
    }

    public IPcBuilder AddRamStick(RandomAccessMemory ram)
    {
        _ram.Add(ram);
        return this;
    }

    public PcBuildResult Build()
    {
        var parts = new PersonalComputerParts(
            _motherboard,
            _cpu,
            _gpu,
            _hdds,
            _ssds,
            _coolingSystem,
            _pcCase,
            _ram,
            _powerSupply,
            _wifiAdapter);
        ComputerStatus result = _validator.ValidateBuild(parts);
        return new PcBuildResult(parts, result);
    }
}