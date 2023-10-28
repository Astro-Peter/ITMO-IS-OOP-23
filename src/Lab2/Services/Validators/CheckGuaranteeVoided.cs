using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class CheckGuaranteeVoided : IValidator
{
    public ComputerStatus ValidateBuild(PersonalComputerParts parts)
    {
        return new ComputerStatus(
            parts.Cpu.Tdp <= parts.CoolingSystem.Tdp,
            PowerConsumptionStatus.None,
            new Collection<string>());
    }
}