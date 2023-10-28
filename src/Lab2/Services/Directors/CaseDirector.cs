using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CaseBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class CaseDirector : IBaseDirector<ICaseBuilder>
{
    private readonly PcCase _pcCase;

    public CaseDirector(PcCase pcCase)
    {
        _pcCase = pcCase;
    }

    public ICaseBuilder Direct(ICaseBuilder baseBuilder)
    {
        baseBuilder.SetName(_pcCase.Name)
            .SetDimensions(_pcCase.Dimensions)
            .SetMaximumGpuDimensions(_pcCase.GpuDimensions)
            .SetMotherboardFormFactor(_pcCase.FormFactor);
        return baseBuilder;
    }
}