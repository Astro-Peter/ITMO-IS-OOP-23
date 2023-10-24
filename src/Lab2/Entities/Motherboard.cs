using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record Motherboard(string Socket,
    int PciELines,
    int SataPorts,
    string DdrStandard,
    int RamSlots,
    MotherBoardFormFactor FormFactor,
    Bios Bios);