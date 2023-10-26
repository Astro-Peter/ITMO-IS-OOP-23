﻿using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.MotherBoardBuilder;

public interface IMotherboardBuilder : IBaseBuilder<Motherboard>,
    ISetPciEx16LanesNumber<IMotherboardBuilder>,
    ISetPciEx4LanesNumber<IMotherboardBuilder>,
    ISetPciEx1LanesNumber<IMotherboardBuilder>,
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