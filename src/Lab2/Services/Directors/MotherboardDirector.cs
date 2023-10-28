using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.MotherboardBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class MotherboardDirector : IBaseDirector<IMotherboardBuilder>
{
    private Motherboard _motherboard;

    public MotherboardDirector(Motherboard motherboard)
    {
        _motherboard = motherboard;
    }

    public IMotherboardBuilder Direct(IMotherboardBuilder baseBuilder)
    {
        baseBuilder.SetBios(_motherboard.Bios)
            .SetDdrVersion(_motherboard.DdrStandard)
            .SetChipset(_motherboard.Chipset)
            .SetName(_motherboard.Name)
            .SetSocket(_motherboard.Socket)
            .SetMotherboardFormFactor(_motherboard.FormFactor)
            .SetRamSlots(_motherboard.RamSlots)
            .SetSataPortsNumber(_motherboard.SataPorts)
            .SetPciEx1LanesNumber(_motherboard.PciEx1Lanes)
            .SetPciEx4LanesNumber(_motherboard.PciEx4Lanes)
            .SetPciEx16LanesNumber(_motherboard.PciEx16Lanes);
        return baseBuilder;
    }
}