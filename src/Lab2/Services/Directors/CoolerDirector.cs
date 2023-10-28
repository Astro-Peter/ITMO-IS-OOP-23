using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CoolerBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class CoolerDirector : IBaseDirector<ICoolerBuilder>
{
    private CoolingSystem _cooler;
    public CoolerDirector(CoolingSystem cooler)
    {
        _cooler = cooler;
    }

    public ICoolerBuilder Direct(ICoolerBuilder baseBuilder)
    {
        baseBuilder.SetName(_cooler.Name)
            .SetTdp(_cooler.Tdp)
            .SetDimensions(_cooler.Dimensions)
            .SetCompatibleSockets(_cooler.CompatibleSockets);
        return baseBuilder;
    }
}