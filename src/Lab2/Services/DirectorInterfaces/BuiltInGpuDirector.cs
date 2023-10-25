using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuiltInGpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class BuiltInGpuDirector : IBaseDirector<BuiltInGpu, IBuiltInGpuBuilder>
{
    public BuiltInGpuDirector(IBuiltInGpuBuilder builder)
    {
        Builder = builder;
    }

    public IBuiltInGpuBuilder Builder { get; set; }

    public void BuildWith(IBuiltInGpuBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(BuiltInGpu baseComponent)
    {
        Builder.SetFrequency(baseComponent.Frequency)
            .SetName(baseComponent.Name);
    }

    public BuiltInGpu GetComponent()
    {
        return Builder.Build();
    }
}