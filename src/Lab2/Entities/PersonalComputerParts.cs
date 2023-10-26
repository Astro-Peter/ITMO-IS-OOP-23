using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record PersonalComputerParts(
    Motherboard Motherboard,
    Cpu Cpu,
    Gpu? Gpu,
    IList<Hdd>? Hdds,
    IList<Ssd>? Ssds,
    CoolingSystem CoolingSystem,
    PcCase PcCase,
    IList<RandomAccessMemory> Ram,
    PowerSupply PowerSupply,
    WifiAdapter? WifiAdapter);