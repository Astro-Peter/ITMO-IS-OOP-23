using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.MotherBoardBuilder;

public interface IMotherboardBuilder : IBaseBuilder<Motherboard>,
    ISetPciELinesNumber<IMotherboardBuilder>,
    ISetSocket<IMotherboardBuilder>,
    ISetSataPortsNumber<IMotherboardBuilder>,
    ISetDdrVersion<IMotherboardBuilder>,
    ISetRamSlots<IMotherboardBuilder>,
    ISetMotherboardFormFactor<IMotherboardBuilder>,
    ISetBios<IMotherboardBuilder>,
    ISetChipset<IMotherboardBuilder>,
    ISetName<IMotherboardBuilder>
{
}