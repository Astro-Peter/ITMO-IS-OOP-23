using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;

public interface IPcBuilder : IBaseBuilder<PersonalComputerParts>
{
    public IPcBuilder SetMotherBoard(Motherboard motherboard);
    public IPcBuilder SetCpu(Cpu cpu);
    public IPcBuilder SetGpu(Gpu? gpu);
    public IPcBuilder SetHdds(IList<Hdd>? hdds);
    public IPcBuilder SetSsds(IList<Ssd>? ssds);
    public IPcBuilder SetCoolingSystem(CoolingSystem coolingSystem);
    public IPcBuilder SetPcCase(PcCase pcCase);
    public IPcBuilder SetRam(IList<RandomAccessMemory> ram);
    public IPcBuilder SetPowerSupply(PowerSupply powerSupply);
    public IPcBuilder SetWifiAdapter(WifiAdapter? wifiAdapter);
    public IPcBuilder AddHdd(Hdd hdd);
    public IPcBuilder AddSsd(Ssd ssd);
    public IPcBuilder AddRamStick(RandomAccessMemory ram);
}