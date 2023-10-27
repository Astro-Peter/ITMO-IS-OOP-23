using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class CheckGuaranteeVoided : ICheckGuaranteeVoided
{
    public bool CheckCpuAndCooler(PersonalComputerParts parts)
    {
        return parts.Cpu.Tdp <= parts.CoolingSystem.Tdp;
    }
}