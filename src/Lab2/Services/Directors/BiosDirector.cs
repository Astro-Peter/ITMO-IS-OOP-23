using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class BiosDirector : IBaseDirector<IBiosBuilder>
{
    private readonly Bios _bios;

    public BiosDirector(Bios bios)
    {
        _bios = bios;
    }

    public IBiosBuilder Direct(IBiosBuilder baseBuilder)
    {
        baseBuilder.SetBiosType(_bios.Type)
            .SetBiosVersion(_bios.Version)
            .SetCompatibleCpus(_bios.CompatibleCpus);
        return baseBuilder;
    }
}