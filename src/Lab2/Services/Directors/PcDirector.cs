using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class PcDirector : IPcDirector
{
    public PcDirector(
        IPcBuilder builder,
        IPartsCompatibilityValidator partsCompatibilityValidator,
        ICheckGuaranteeVoided check,
        IPowerSupplyValidator powerValidator)
    {
        Builder = builder;
        PartsCompatibilityValidator = partsCompatibilityValidator;
        PowerValidator = powerValidator;
        Check = check;
    }

    public IPcBuilder Builder { get; private set; }
    private IPartsCompatibilityValidator PartsCompatibilityValidator { get; set; }
    private IPowerSupplyValidator PowerValidator { get; set; }
    private ICheckGuaranteeVoided Check { get; set; }

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
        ComputerStatus attempt = AttemptBuild();
        if (attempt.Status == PowerConsumptionStatus.NotEnoughPower)
        {
            throw new IncorrectPcBuildException("Power consumption too high");
        }

        if (attempt.Message.Count > 0)
        {
            throw new IncorrectPcBuildException("some parts are incompatible");
        }

        return Builder.Build();
    }

    public ComputerStatus AttemptBuild()
    {
        PersonalComputerParts parts = Builder.Build();
        return new ComputerStatus(
            Check.CheckCpuAndCooler(parts),
            PowerValidator.CheckEnoughPower(parts),
            PartsCompatibilityValidator.Validate(parts));
    }

    public void WithValidator(IPartsCompatibilityValidator validator)
    {
        PartsCompatibilityValidator = validator;
    }

    public void WithPowerValidator(IPowerSupplyValidator validator)
    {
        PowerValidator = validator;
    }

    public void WithGuaranteeCheck(ICheckGuaranteeVoided guarantee)
    {
        Check = guarantee;
    }
}