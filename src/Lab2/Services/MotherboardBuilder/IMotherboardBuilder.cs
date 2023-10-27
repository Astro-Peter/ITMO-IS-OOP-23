using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.MotherBoardBuilder;

public interface IMotherboardBuilder : IBaseBuilder<Motherboard>
{
    public IMotherboardBuilder SetPciEx16LanesNumber(int lanesNumber);
    public IMotherboardBuilder SetPciEx4LanesNumber(int lanesNumber);
    public IMotherboardBuilder SetPciEx1LanesNumber(int lanesNumber);
    public IMotherboardBuilder SetSocket(string socket);
    public IMotherboardBuilder SetSataPortsNumber(int portsNumber);
    public IMotherboardBuilder SetDdrVersion(string ddrVersion);
    public IMotherboardBuilder SetRamSlots(int ramSlots);
    public IMotherboardBuilder SetMotherboardFormFactor(MotherBoardFormFactor formFactor);
    public IMotherboardBuilder SetBios(Bios bios);
    public IMotherboardBuilder SetChipset(Chipset chipset);
    public IMotherboardBuilder SetName(string name);
}