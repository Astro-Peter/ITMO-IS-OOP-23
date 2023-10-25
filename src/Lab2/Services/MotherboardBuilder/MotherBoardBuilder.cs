using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.MotherBoardBuilder;

public class MotherBoardBuilder : IMotherboardBuilder
{
    private string? Socket { get; set; }
    private int? SataPortsNumber { get; set; }
    private string? DdrVersion { get; set; }
    private int? RamSlots { get; set; }
    private int? PciEx16LanesNumber { get; set; }
    private int? PciEx4LanesNumber { get; set; }
    private int? PciEx1LanesNumber { get; set; }
    private Bios? Bios { get; set; }
    private string? Name { get; set; }
    private Chipset? Chipset { get; set; }
    private MotherBoardFormFactor? MotherBoardFormFactor { get; set; }

    public Motherboard Build()
    {
        return new Motherboard(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            Socket ?? throw new UndefinedParameterException(nameof(Socket)),
            PciEx16LanesNumber ?? throw new UndefinedParameterException(nameof(PciEx16LanesNumber)),
            PciEx4LanesNumber ?? throw new UndefinedParameterException(nameof(PciEx4LanesNumber)),
            PciEx1LanesNumber ?? throw new UndefinedParameterException(nameof(PciEx1LanesNumber)),
            SataPortsNumber ?? throw new UndefinedParameterException(nameof(SataPortsNumber)),
            Chipset ?? throw new UndefinedParameterException(nameof(Chipset)),
            DdrVersion ?? throw new UndefinedParameterException(nameof(DdrVersion)),
            RamSlots ?? throw new UndefinedParameterException(nameof(RamSlots)),
            MotherBoardFormFactor ?? throw new UndefinedParameterException(nameof(MotherBoardFormFactor)),
            Bios ?? throw new UndefinedParameterException(nameof(Bios)));
    }

    public IMotherboardBuilder SetSocket(string socket)
    {
        Socket = socket;
        return this;
    }

    public IMotherboardBuilder SetSataPortsNumber(int portsNumber)
    {
        SataPortsNumber = portsNumber;
        return this;
    }

    public IMotherboardBuilder SetDdrVersion(string ddrVersion)
    {
        DdrVersion = ddrVersion;
        return this;
    }

    public IMotherboardBuilder SetRamSlots(int ramSlots)
    {
        RamSlots = ramSlots;
        return this;
    }

    public IMotherboardBuilder SetMotherboardFormFactor(MotherBoardFormFactor formFactor)
    {
        MotherBoardFormFactor = formFactor;
        return this;
    }

    public IMotherboardBuilder SetBios(Bios bios)
    {
        Bios = bios;
        return this;
    }

    public IMotherboardBuilder SetChipset(Chipset chipset)
    {
        Chipset = chipset;
        return this;
    }

    public IMotherboardBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IMotherboardBuilder SetPciEx16LanesNumber(int lanesNumber)
    {
        PciEx16LanesNumber = lanesNumber;
        return this;
    }

    public IMotherboardBuilder SetPciEx4LanesNumber(int lanesNumber)
    {
        PciEx4LanesNumber = lanesNumber;
        return this;
    }

    public IMotherboardBuilder SetPciEx1LanesNumber(int lanesNumber)
    {
        PciEx1LanesNumber = lanesNumber;
        return this;
    }
}