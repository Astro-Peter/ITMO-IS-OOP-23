using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.HddBuilder;

public interface IHddBuilder : IBaseBuilder<Hdd>,
    ISetMemoryCapacity<IHddBuilder>,
    ISetPower<IHddBuilder>,
    ISetName<IHddBuilder>,
    ISetRpm<IHddBuilder>
{
}