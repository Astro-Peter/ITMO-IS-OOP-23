using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuiltInGpuBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class BuiltInGpuDirector : IBaseDirector<IBuiltInGpuBuilder>
{
    private readonly BuiltInGpu _gpu;

    public BuiltInGpuDirector(BuiltInGpu gpu)
    {
        _gpu = gpu;
    }

    public IBuiltInGpuBuilder Direct(IBuiltInGpuBuilder baseBuilder)
    {
        baseBuilder.SetFrequency(_gpu.Frequency)
            .SetName(_gpu.Name);
        return baseBuilder;
    }
}