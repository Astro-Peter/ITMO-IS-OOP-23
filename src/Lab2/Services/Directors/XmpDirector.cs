using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class XmpDirector : IBaseDirector<IXmpBuilder>
{
    private readonly XmpProfile _xmp;

    public XmpDirector(XmpProfile xmp)
    {
        _xmp = xmp;
    }

    public IXmpBuilder Direct(IXmpBuilder baseBuilder)
    {
        baseBuilder.SetFrequency(_xmp.Frequency)
            .SetName(_xmp.Name)
            .SetTimings(_xmp.Timings)
            .SetVoltage(_xmp.Voltage);
        return baseBuilder;
    }
}