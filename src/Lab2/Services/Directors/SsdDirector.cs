using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.SsdBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class SsdDirector : IBaseDirector<ISsdBuilder>
{
    private Ssd _ssd;

    public SsdDirector(Ssd ssd)
    {
        _ssd = ssd;
    }

    public ISsdBuilder Direct(ISsdBuilder baseBuilder)
    {
        baseBuilder.SetName(_ssd.Name)
            .SetPower(_ssd.PowerUsage)
            .SetMemoryCapacity(_ssd.Capacity)
            .SetSpeed(_ssd.Speed)
            .SetConnectionType(_ssd.ConnectionType);
        return baseBuilder;
    }
}