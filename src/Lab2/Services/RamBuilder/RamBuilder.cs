using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;

public class RamBuilder : IRamBuilder
{
    private string? Name { get; set; }
    private int? MemoryCapacity { get; set; }
    private string? RamFormFactor { get; set; }
    private string? DdrVersion { get; set; }
    private int? Power { get; set; }
    private string? Jedec { get; set; }
    private IList<XmpProfile>? XmpProfiles { get; set; }
    public RandomAccessMemory Build()
    {
        return new RandomAccessMemory(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            MemoryCapacity ?? throw new UndefinedParameterException(nameof(MemoryCapacity)),
            Jedec ?? throw new UndefinedParameterException(nameof(Jedec)),
            XmpProfiles ?? throw new UndefinedParameterException(nameof(XmpProfiles)),
            RamFormFactor ?? throw new UndefinedParameterException(nameof(RamFormFactor)),
            DdrVersion ?? throw new UndefinedParameterException(nameof(DdrVersion)),
            Power ?? throw new UndefinedParameterException(nameof(Power)));
    }

    public IRamBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IRamBuilder SetMemoryCapacity(int memoryCapacity)
    {
        MemoryCapacity = memoryCapacity;
        return this;
    }

    public IRamBuilder SetRamFormFactor(string ramFormFactor)
    {
        RamFormFactor = ramFormFactor;
        return this;
    }

    public IRamBuilder SetDdrVersion(string ddrVersion)
    {
        DdrVersion = ddrVersion;
        return this;
    }

    public IRamBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }

    public IRamBuilder SetJedec(string jedec)
    {
        Jedec = jedec;
        return this;
    }

    public IRamBuilder SetXmpProfiles(IList<XmpProfile> xmpProfiles)
    {
        XmpProfiles = xmpProfiles;
        return this;
    }
}