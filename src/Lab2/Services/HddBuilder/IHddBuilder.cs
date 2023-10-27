using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.HddBuilder;

public interface IHddBuilder : IBaseBuilder<Hdd>
{
    public IHddBuilder SetMemoryCapacity(int memoryCapacity);
    public IHddBuilder SetPower(int powerUsage);
    public IHddBuilder SetName(string name);
    public IHddBuilder SetRpm(int rpm);
}