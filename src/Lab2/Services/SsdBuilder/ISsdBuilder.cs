using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.SsdBuilder;

public interface ISsdBuilder : IBaseBuilder<Ssd>,
    ISetName<ISsdBuilder>,
    ISetConnectionType<ISsdBuilder>,
    ISetMemoryCapacity<ISsdBuilder>,
    ISetSpeed<ISsdBuilder>,
    ISetPower<ISsdBuilder>
{
}