using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.MotherboardBuilder;

public class MotherBoardBuilder : IMotherboardBuilder
{
    private string _socket = "none";
    private int _sataPortsNumber;
    private string _ddrVersion = "none";
    private int _ramSlots;
    private int _pciEx16LanesNumber;
    private int _pciEx4LanesNumber;
    private int _pciEx1LanesNumber;
    private Bios _bios = new BiosBuilder.BiosBuilder().Build();
    private string _name = "none";
    private Chipset _chipset = new ChipsetBuilder.ChipsetBuilder().Build();
    private MotherBoardFormFactor _motherBoardFormFactor = MotherBoardFormFactor.None;

    public Motherboard Build()
    {
        return new Motherboard(
            _name,
            _socket,
            _pciEx16LanesNumber,
            _pciEx4LanesNumber,
            _pciEx1LanesNumber,
            _sataPortsNumber,
            _chipset,
            _ddrVersion,
            _ramSlots,
            _motherBoardFormFactor,
            _bios);
    }

    public IMotherboardBuilder SetSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public IMotherboardBuilder SetSataPortsNumber(int portsNumber)
    {
        _sataPortsNumber = portsNumber;
        return this;
    }

    public IMotherboardBuilder SetDdrVersion(string ddrVersion)
    {
        _ddrVersion = ddrVersion;
        return this;
    }

    public IMotherboardBuilder SetRamSlots(int ramSlots)
    {
        _ramSlots = ramSlots;
        return this;
    }

    public IMotherboardBuilder SetMotherboardFormFactor(MotherBoardFormFactor formFactor)
    {
        _motherBoardFormFactor = formFactor;
        return this;
    }

    public IMotherboardBuilder SetBios(Bios bios)
    {
        _bios = bios;
        return this;
    }

    public IMotherboardBuilder SetChipset(Chipset chipset)
    {
        _chipset = chipset;
        return this;
    }

    public IMotherboardBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IMotherboardBuilder SetPciEx16LanesNumber(int lanesNumber)
    {
        _pciEx16LanesNumber = lanesNumber;
        return this;
    }

    public IMotherboardBuilder SetPciEx4LanesNumber(int lanesNumber)
    {
        _pciEx4LanesNumber = lanesNumber;
        return this;
    }

    public IMotherboardBuilder SetPciEx1LanesNumber(int lanesNumber)
    {
        _pciEx1LanesNumber = lanesNumber;
        return this;
    }
}