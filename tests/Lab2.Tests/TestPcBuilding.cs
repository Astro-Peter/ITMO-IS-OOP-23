using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.MotherboardBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class TestPcBuilding
{
    private static readonly Repositories _repos = new Repositories(
        new Repository<Bios>(),
        new Repository<BuiltInGpu>(),
        new Repository<Chipset>(),
        new Repository<CoolingSystem>()
        {
            new CoolingSystem("cooler1", new Dimensions(5, 5, 5), new List<string>() { "plcc" }, 40),
            new CoolingSystem("cooler2", new Dimensions(5, 5, 5), new List<string>() { "plcc" }, 10),
        },
        new Repository<Cpu>()
        {
            new Cpu("cpu1", 10, 2, "plcc", null, 100, 20, 40),
            new Cpu("cpu2", 10, 2, "plcc", null, 10, 20, 40),
            new Cpu("cpu3", 10, 2, "plcc", null, 10, 20, 40),
        },
        new Repository<Gpu>()
        {
            new Gpu("gpu1", new Dimensions(1, 1, 1), 1, "4.0", 10, 50),
        },
        new Repository<Hdd>(),
        new Repository<Motherboard>(),
        new Repository<PcCase>()
        {
            new PcCase(new Dimensions(400, 400, 400), MotherBoardFormFactor.Atx, new Dimensions(20, 40, 50), "case1"),
        },
        new Repository<PowerSupply>()
        {
            new PowerSupply(400, "power1"),
            new PowerSupply(100, "power2"),
        },
        new Repository<RandomAccessMemory>(),
        new Repository<Ssd>(new Collection<Ssd>()
        {
            new Ssd("sata", 20, 20, 20, "ssd1"),
            new Ssd("pcie", 20, 20, 20, "ssd2"),
        }),
        new Repository<WifiAdapter>(),
        new Repository<XmpProfile>());

    public TestPcBuilding()
    {
        var xmpBuilder = new XmpBuilder();
        xmpBuilder.SetFrequency(20)
            .SetName("xmp1")
            .SetTimings("10-20-20-30")
            .SetVoltage(1.4);

        var ramBuilder = new RamBuilder();
        ramBuilder.SetName("ram1")
            .SetJedec("10-20-30-30")
            .SetDdrVersion("ddr4")
            .SetPower(30)
            .SetMemoryCapacity(200)
            .SetRamFormFactor("smth")
            .SetXmpProfiles(new List<XmpProfile>()
            {
                xmpBuilder.Build(),
            });
        _repos.RamSticks.Add(ramBuilder.Build());

        var biosBuilder = new BiosBuilder();
        biosBuilder.SetBiosType("amibios")
            .SetBiosVersion("2200")
            .SetCompatibleCpus(new List<string>()
            {
                "cpu1",
                "cpu2",
            });

        var chipsetBuilder = new ChipsetBuilder();
        chipsetBuilder.SetName("x220")
            .SetXmpSupport(true)
            .SetAvailableMemoryFrequencies(new List<double>()
            {
                20,
            });

        var motherboardBuilder = new MotherBoardBuilder();
        motherboardBuilder.SetName("skiddly-doo")
            .SetDdrVersion("ddr4")
            .SetBios(biosBuilder.Build())
            .SetChipset(chipsetBuilder.Build())
            .SetSocket("plcc")
            .SetRamSlots(2)
            .SetMotherboardFormFactor(MotherBoardFormFactor.Atx)
            .SetPciEx1LanesNumber(1)
            .SetPciEx4LanesNumber(2)
            .SetPciEx16LanesNumber(1)
            .SetSataPortsNumber(1);
        _repos.Motherboards.Add(motherboardBuilder.Build());
    }

    [Fact]
    public void CorrectPcConfiguration()
    {
        var builder = new PcBuilder();
        builder.AddSsd(_repos.Ssds.First())
            .AddRamStick(_repos.RamSticks.First())
            .SetCpu(_repos.Cpus.First())
            .SetGpu(_repos.Gpus.First())
            .SetMotherBoard(_repos.Motherboards.First())
            .SetCoolingSystem(_repos.CoolingSystems.First())
            .SetPcCase(_repos.PcCases.First())
            .SetPowerSupply(_repos.PowerSupplies.First());
        PcBuildResult result = builder.Build();
        Assert.Empty(result.Status.Message);
        Assert.Equal(PowerConsumptionStatus.EnoughPower, result.Status.Status);
    }

    [Fact]
    public void PowerConsumptionMoreThanRecommended()
    {
        var builder = new PcBuilder();
        builder.AddSsd(_repos.Ssds.First())
            .AddRamStick(_repos.RamSticks.First())
            .SetCpu(_repos.Cpus.First())
            .SetGpu(_repos.Gpus.First())
            .SetMotherBoard(_repos.Motherboards.First())
            .SetCoolingSystem(_repos.CoolingSystems.First())
            .SetPcCase(_repos.PcCases.First())
            .SetPowerSupply(_repos.PowerSupplies.First(supply => supply.Name == "power2"));
        PcBuildResult result = builder.Build();
        Assert.Empty(result.Status.Message);
        Assert.Equal(PowerConsumptionStatus.RiskZone, result.Status.Status);
    }

    [Fact]
    public void GuaranteeVoidedBecauseOfBadCooler()
    {
        var builder = new PcBuilder();
        builder.AddSsd(_repos.Ssds.First())
            .AddRamStick(_repos.RamSticks.First())
            .SetCpu(_repos.Cpus.First())
            .SetGpu(_repos.Gpus.First())
            .SetMotherBoard(_repos.Motherboards.First())
            .SetCoolingSystem(_repos.CoolingSystems.First(system => system.Tdp == 10))
            .SetPcCase(_repos.PcCases.First())
            .SetPowerSupply(_repos.PowerSupplies.First());
        PcBuildResult result = builder.Build();
        Assert.Empty(result.Status.Message);
        Assert.False(result.Status.Guarantee);
    }

    [Fact]
    public void FailureToBuild()
    {
        var builder = new PcBuilder();
        builder.AddSsd(_repos.Ssds.First())
            .AddSsd(_repos.Ssds.First())
            .AddSsd(_repos.Ssds.First())
            .AddSsd(_repos.Ssds.First())
            .AddSsd(_repos.Ssds.First())
            .AddRamStick(_repos.RamSticks.First())
            .AddRamStick(_repos.RamSticks.First())
            .AddRamStick(_repos.RamSticks.First())
            .AddRamStick(_repos.RamSticks.First())
            .SetCpu(_repos.Cpus.First())
            .SetGpu(_repos.Gpus.First())
            .SetMotherBoard(_repos.Motherboards.First())
            .SetCoolingSystem(_repos.CoolingSystems.First())
            .SetPcCase(_repos.PcCases.First())
            .SetPowerSupply(_repos.PowerSupplies.First());
        PcBuildResult result = builder.Build();
        Assert.Equal(2, result.Status.Message.Count);
        Assert.Contains("not enough sata ports", result.Status.Message);
        Assert.Contains("not enough ram slots", result.Status.Message);
    }
}