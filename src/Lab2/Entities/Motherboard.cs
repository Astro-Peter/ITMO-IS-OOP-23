using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record Motherboard(
    string Name,
    string Socket,
    int PciEx16Lanes,
    int PciEx4Lanes,
    int PciEx1Lanes,
    int SataPorts,
    Chipset Chipset,
    string DdrStandard,
    int RamSlots,
    MotherBoardFormFactor FormFactor,
    Bios Bios);