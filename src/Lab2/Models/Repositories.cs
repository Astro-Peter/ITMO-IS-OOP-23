using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Repositories;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public record Repositories(
    IRepository<Bios> Bioses,
    IRepository<BuiltInGpu> BuiltInGpus,
    IRepository<Chipset> Chipsets,
    IRepository<CoolingSystem> CoolingSystems,
    IRepository<Cpu> Cpus,
    IRepository<Gpu> Gpus,
    IRepository<Hdd> Hdds,
    IRepository<Motherboard> Motherboards,
    IRepository<PcCase> PcCases,
    IRepository<PowerSupply> PowerSupplies,
    IRepository<RandomAccessMemory> RamSticks,
    IRepository<Ssd> Ssds,
    IRepository<WifiAdapter> WifiAdapters,
    IRepository<XmpProfile> XmpProfiles);