using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

public interface IBiosBuilder : IBaseBuilder<Bios>,
    ISetBiosType<IBiosBuilder>,
    ISetBiosVersion<IBiosBuilder>,
    ISetCompatibleCpus<IBiosBuilder>
{
}