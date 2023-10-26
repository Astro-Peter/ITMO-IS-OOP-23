using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PartsCompatabilityValidator;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class PcDirector : IPcDirector
{
    public PcDirector(IPcBuilder builder, IComputerValidator validator)
    {
        Builder = builder;
        Validator = validator;
    }

    public IPcBuilder Builder { get; private set; }
    private IComputerValidator Validator { get; set; }

    public void BuildWith(IPcBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(PersonalComputerParts baseComponent)
    {
        Builder.SetHdds(baseComponent.Hdds)
            .SetCpu(baseComponent.Cpu)
            .SetGpu(baseComponent.Gpu)
            .SetRam(baseComponent.Ram)
            .SetSsds(baseComponent.Ssds)
            .SetCoolingSystem(baseComponent.CoolingSystem)
            .SetMotherBoard(baseComponent.Motherboard)
            .SetPcCase(baseComponent.PcCase)
            .SetPowerSupply(baseComponent.PowerSupply)
            .SetWifiAdapter(baseComponent.WifiAdapter);
    }

    public PersonalComputerParts GetComponent()
    {
        return Builder.Build();
    }

    public ComputerStatus AttemptBuild()
    {
        return Validator.Validate(Builder.Build());
    }

    public void WithValidator(IComputerValidator validator)
    {
        Validator = validator;
    }
}