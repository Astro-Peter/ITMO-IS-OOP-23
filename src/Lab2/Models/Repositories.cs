using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Repositories;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public record Repositories(
    Repository<Bios> Bioses,
    Repository<BuiltInGpu> BuiltInGpus,
    Repository<Chipset> Chipsets,
    Repository<CoolingSystem> CoolingSystems,
    Repository<Cpu> Cpus,
    Repository<Gpu> Gpus,
    Repository<Hdd> Hdds,
    Repository<Motherboard> Motherboards,
    Repository<PcCase> PcCases,
    Repository<PowerSupply> PowerSupplies,
    Repository<RandomAccessMemory> RamSticks,
    Repository<Ssd> Ssds,
    Repository<WifiAdapter> WifiAdapters,
    Repository<XmpProfile> XmpProfiles);