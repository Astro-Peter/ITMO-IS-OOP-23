using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.SsdBuilder;

public interface ISsdBuilder : IBaseBuilder<Ssd>
{
    public ISsdBuilder SetName(string name);
    public ISsdBuilder SetConnectionType(string connectionType);
    public ISsdBuilder SetMemoryCapacity(int memoryCapacity);
    public ISsdBuilder SetSpeed(int speed);
    public ISsdBuilder SetPower(int powerUsage);
}