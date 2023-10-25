using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CaseBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.CpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class CaseDirector : IBaseDirector<PcCase, ICaseBuilder>
{
    public CaseDirector(ICaseBuilder builder)
    {
        Builder = builder;
    }

    public ICaseBuilder Builder { get; private set; }

    public void BuildWith(ICaseBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(PcCase baseComponent)
    {
        Builder.SetName(baseComponent.Name)
            .SetDimensions(baseComponent.Dimensions)
            .SetMaximumGpuDimensions(baseComponent.GpuDimensions)
            .SetMotherboardFormFactor(baseComponent.FormFactor);
    }

    public PcCase GetComponent()
    {
        return Builder.Build();
    }
}