using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.XmpBuilder;

public interface IXmpBuilder : IBaseBuilder<XmpProfile>,
    ISetName<IXmpBuilder>,
    ISetFrequency<IXmpBuilder>,
    ISetVoltage<IXmpBuilder>,
    ISetTimings<IXmpBuilder>
{
}