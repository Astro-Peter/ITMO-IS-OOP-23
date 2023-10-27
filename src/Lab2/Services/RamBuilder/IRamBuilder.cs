using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;

public interface IRamBuilder : IBaseBuilder<RandomAccessMemory>
{
    public IRamBuilder SetName(string name);
    public IRamBuilder SetMemoryCapacity(int memoryCapacity);
    public IRamBuilder SetRamFormFactor(string ramFormFactor);
    public IRamBuilder SetDdrVersion(string ddrVersion);
    public IRamBuilder SetPower(int powerUsage);
    public IRamBuilder SetJedec(string jedec);
    public IRamBuilder SetXmpProfiles(IList<XmpProfile> xmpProfiles);
}