using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.RamBuilder;

public interface IRamBuilder : IBaseBuilder<RandomAccessMemory>,
    ISetName<IRamBuilder>,
    ISetMemoryCapacity<IRamBuilder>,
    ISetRamFormFactor<IRamBuilder>,
    ISetDdrVersion<IRamBuilder>,
    ISetPower<IRamBuilder>,
    ISetJedec<IRamBuilder>,
    ISetXmpProfiles<IRamBuilder>
{
}