using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.MotherBoardBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class MotherboardDirector : IBaseDirector<Motherboard, IMotherboardBuilder>
{
    public MotherboardDirector(IMotherboardBuilder builder)
    {
        Builder = builder;
    }

    public IMotherboardBuilder Builder { get; private set; }

    public void BuildWith(IMotherboardBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Motherboard baseComponent)
    {
        Builder.SetBios(baseComponent.Bios)
            .SetDdrVersion(baseComponent.DdrStandard)
            .SetChipset(baseComponent.Chipset)
            .SetName(baseComponent.Name)
            .SetSocket(baseComponent.Socket)
            .SetMotherboardFormFactor(baseComponent.FormFactor)
            .SetRamSlots(baseComponent.RamSlots)
            .SetSataPortsNumber(baseComponent.SataPorts)
            .SetPciEx1LanesNumber(baseComponent.PciEx1Lanes)
            .SetPciEx4LanesNumber(baseComponent.PciEx4Lanes)
            .SetPciEx16LanesNumber(baseComponent.PciEx16Lanes);
    }

    public Motherboard GetComponent()
    {
        return Builder.Build();
    }
}