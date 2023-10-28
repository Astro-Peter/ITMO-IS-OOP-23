using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;

public class RamBuilder : IRamBuilder
{
    private string _ddrVersion = "none";
    private string _jedec = "none";
    private int _memoryCapacity;
    private string _name = "none";
    private int _power;
    private string _ramFormFactor = "none";
    private IList<XmpProfile> _xmpProfiles = new Collection<XmpProfile>();

    public RandomAccessMemory Build()
    {
        return new RandomAccessMemory(
            _name,
            _memoryCapacity,
            _jedec,
            _xmpProfiles,
            _ramFormFactor,
            _ddrVersion,
            _power);
    }

    public IRamBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IRamBuilder SetMemoryCapacity(int memoryCapacity)
    {
        _memoryCapacity = memoryCapacity;
        return this;
    }

    public IRamBuilder SetRamFormFactor(string ramFormFactor)
    {
        _ramFormFactor = ramFormFactor;
        return this;
    }

    public IRamBuilder SetDdrVersion(string ddrVersion)
    {
        _ddrVersion = ddrVersion;
        return this;
    }

    public IRamBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }

    public IRamBuilder SetJedec(string jedec)
    {
        _jedec = jedec;
        return this;
    }

    public IRamBuilder SetXmpProfiles(IList<XmpProfile> xmpProfiles)
    {
        _xmpProfiles = xmpProfiles;
        return this;
    }
}