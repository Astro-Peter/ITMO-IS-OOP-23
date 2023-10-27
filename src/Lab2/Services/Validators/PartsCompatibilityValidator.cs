using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Comparators;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class PartsCompatibilityValidator : IPartsCompatibilityValidator
{
    public IList<string> Validate(PersonalComputerParts parts)
    {
        var issues = new List<string?>
        {
            ValidateBiosCompatibility(parts.Cpu, parts.Motherboard.Bios),
            ValidateGpuFits(parts.Gpu, parts.PcCase),
            ValidateHasStorage(parts.Ssds, parts.Hdds),
            ValidateMotherboardCompatible(parts.Motherboard, parts.PcCase),
            ValidateRamCompatibleWithCpu(parts.Ram, parts.Cpu),
            ValidateRamCompatibleWithMotherBoard(parts.Ram, parts.Motherboard),
            ValidateEnoughRamSlots(parts.Ram, parts.Motherboard),
            ValidateSocketCompatibleWithCpu(parts.Cpu, parts.Motherboard),
            ValidateSocketCompatibleWithCoolingSystem(parts.Motherboard, parts.CoolingSystem),
            ValidateCpuGpuCompatability(parts.Cpu, parts.Gpu),
            ValidateEnoughSataPorts(parts.Motherboard, parts.Hdds, parts.Ssds),
            ValidateEnoughPciEx1Lanes(parts.Motherboard, parts.WifiAdapter),
            ValidateEnoughPciEx16Lanes(parts.Motherboard, parts.Gpu),
            ValidateEnoughPciEx4Lanes(parts.Motherboard, parts.Ssds),
        };

        var realIssues = new List<string>();
        foreach (string? issue in issues)
        {
            if (issue is not null)
            {
                realIssues.Add(issue);
            }
        }

        return realIssues;
    }

    private static string? ValidateBiosCompatibility(Cpu cpu, Bios bios)
    {
        if (bios.CompatibleCpus.All(compatibleCpu => cpu.Name != compatibleCpu))
        {
            return (string)(nameof(bios) + "incompatible with " + nameof(cpu));
        }

        return null;
    }

    private static string? ValidateMotherboardCompatible(Motherboard motherboard, PcCase pcCase)
    {
        if (pcCase.FormFactor < motherboard.FormFactor)
        {
            return (string)(nameof(motherboard) + "incompatible with " + nameof(pcCase));
        }

        return null;
    }

    private static string? ValidateSocketCompatibleWithCpu(Cpu cpu, Motherboard motherboard)
    {
        if (cpu.Socket != motherboard.Socket)
        {
            return (string)(nameof(motherboard) + "incompatible with " + nameof(cpu));
        }

        return null;
    }

    private static string? ValidateSocketCompatibleWithCoolingSystem(
        Motherboard motherboard,
        CoolingSystem coolingSystem)
    {
        if (coolingSystem.CompatibleSockets.All(socket => socket != motherboard.Socket))
        {
            return (string)(nameof(coolingSystem) + "incompatible with " + nameof(motherboard));
        }

        return null;
    }

    private static string? ValidateRamCompatibleWithMotherBoard(IList<RandomAccessMemory> ram, Motherboard motherboard)
    {
        if (ram.Any(ramStick => ramStick.DdrVersion != motherboard.DdrStandard))
        {
            return (string)(nameof(ram) + "incompatible with " + nameof(motherboard));
        }

        return null;
    }

    private static string? ValidateEnoughRamSlots(IList<RandomAccessMemory> ram, Motherboard motherboard)
    {
        if (ram.Count > motherboard.RamSlots)
        {
            return "not enough ram slots";
        }

        return null;
    }

    private static string? ValidateRamCompatibleWithCpu(IList<RandomAccessMemory> ram, Cpu cpu)
    {
        if (ram.All(ramStick => ramStick.AvailableProfiles
                .All(profile => profile.Frequency > cpu.MaxRamFrequency)))
        {
            return (string)(nameof(ram) + "incompatible with " + nameof(cpu));
        }

        return null;
    }

    private static string? ValidateGpuFits(Gpu? gpu, PcCase pcCase)
    {
        if (gpu is not null && !CompareDimensions.Compare(gpu.Dimensions, pcCase.GpuDimensions))
        {
            return (string)(nameof(pcCase) + "incompatible with " + nameof(gpu));
        }

        return null;
    }

    private static string? ValidateHasStorage(IList<Ssd>? ssds, IList<Hdd>? hdds)
    {
        if ((ssds is null || ssds.Count == 0) && (hdds is null || hdds.Count == 0))
        {
            return "no storage";
        }

        return null;
    }

    private static string? ValidateEnoughSataPorts(Motherboard motherboard, IList<Hdd>? hdds, IList<Ssd>? ssds)
    {
        int portsNeeded = 0;
        if (hdds is not null)
        {
            portsNeeded += hdds.Count;
        }

        if (ssds is not null)
        {
            portsNeeded += ssds.Sum(x => x.ConnectionType == "sata" ? 1 : 0);
        }

        if (portsNeeded > motherboard.SataPorts)
        {
            return "not enough sata ports";
        }

        return null;
    }

    private static string? ValidateEnoughPciEx1Lanes(
        Motherboard motherboard,
        WifiAdapter? adapter)
    {
        if (adapter is not null && motherboard.PciEx1Lanes == 0)
        {
            return "not enough PciEx1 ports";
        }

        return null;
    }

    private static string? ValidateEnoughPciEx16Lanes(
        Motherboard motherboard,
        Gpu? gpu)
    {
        if (gpu is not null && motherboard.PciEx16Lanes == 0)
        {
            return "not enough PciEx16";
        }

        return null;
    }

    private static string? ValidateEnoughPciEx4Lanes(
        Motherboard motherboard,
        IList<Ssd>? ssds)
    {
        if (ssds is not null &&
            ssds.Sum(ssd => ssd.ConnectionType == "pcie" ? 1 : 0) > motherboard.PciEx4Lanes)
        {
            return "not enough PciEx4";
        }

        return null;
    }

    private static string? ValidateCpuGpuCompatability(Cpu cpu, Gpu? gpu)
    {
        if (gpu is null && cpu.BuiltInGpu is null)
        {
            return "no gpu";
        }

        return null;
    }
}