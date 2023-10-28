using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.HddBuilder;

public class HddBuilder : IHddBuilder
{
    private int _memoryCapacity;
    private int _power;
    private string _name = "none";
    private int _rpm;

    public Hdd Build()
    {
        return new Hdd(
            _memoryCapacity,
            _rpm,
            _power,
            _name);
    }

    public IHddBuilder SetMemoryCapacity(int memoryCapacity)
    {
        _memoryCapacity = memoryCapacity;
        return this;
    }

    public IHddBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }

    public IHddBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IHddBuilder SetRpm(int rpm)
    {
        _rpm = rpm;
        return this;
    }
}