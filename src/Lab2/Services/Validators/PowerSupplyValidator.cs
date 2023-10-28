using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class PowerSupplyValidator : IValidator
{
    public ComputerStatus ValidateBuild(PersonalComputerParts parts)
    {
        return new ComputerStatus(
            false,
            CheckEnoughPower(parts),
            new List<string>());
    }

    private static PowerConsumptionStatus CheckEnoughPower(PersonalComputerParts parts)
    {
        int totalPowerConsumption = parts.Cpu.PowerConsumption +
                                    parts.Ram.Sum(ramStick => ramStick.PowerUsage);
        if (parts.Gpu is not null)
        {
            totalPowerConsumption += parts.Gpu.PowerUsage;
        }

        if (parts.Ssds is not null)
        {
            totalPowerConsumption += parts.Ssds.Sum(ssd => ssd.PowerUsage);
        }

        if (parts.Hdds is not null)
        {
            totalPowerConsumption += parts.Hdds.Sum(hdd => hdd.PowerUsage);
        }

        if (parts.WifiAdapter is not null)
        {
            totalPowerConsumption += parts.WifiAdapter.PowerUsage;
        }

        if (totalPowerConsumption <= parts.PowerSupply.Power)
        {
            return PowerConsumptionStatus.EnoughPower;
        }

        if (totalPowerConsumption <= parts.PowerSupply.Power + 50)
        {
            return PowerConsumptionStatus.RiskZone;
        }

        return PowerConsumptionStatus.NotEnoughPower;
    }
}