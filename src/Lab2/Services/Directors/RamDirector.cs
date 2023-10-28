using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class RamDirector : IBaseDirector<IRamBuilder>
{
    private RandomAccessMemory _ram;
    public RamDirector(RandomAccessMemory ram)
    {
        _ram = ram;
    }

    public IRamBuilder Direct(IRamBuilder baseBuilder)
    {
        baseBuilder.SetJedec(_ram.Jedec)
            .SetName(_ram.Name)
            .SetPower(_ram.PowerUsage)
            .SetDdrVersion(_ram.DdrVersion)
            .SetMemoryCapacity(_ram.MemoryAmount)
            .SetXmpProfiles(_ram.AvailableProfiles)
            .SetRamFormFactor(_ram.RamFormFactor);
        return baseBuilder;
    }
}