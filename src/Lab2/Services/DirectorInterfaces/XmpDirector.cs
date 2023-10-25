using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.DirectorInterfaces;

public class XmpDirector : IBaseDirector<XmpProfile, IXmpBuilder>
{
    public XmpDirector(IXmpBuilder builder)
    {
        Builder = builder;
    }

    public IXmpBuilder Builder { get; private set; }

    public void BuildWith(IXmpBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(XmpProfile baseComponent)
    {
        Builder.SetFrequency(baseComponent.Frequency)
            .SetName(baseComponent.Name)
            .SetTimings(baseComponent.Timings)
            .SetVoltage(baseComponent.Voltage);
    }

    public XmpProfile GetComponent()
    {
        return Builder.Build();
    }
}