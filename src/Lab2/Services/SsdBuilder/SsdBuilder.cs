using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.SsdBuilder;

public class SsdBuilder : ISsdBuilder
{
    private string _connectionType = "none";
    private int _memoryCapacity;
    private string _name = "none";
    private int _power;
    private int _speed;

    public Ssd Build()
    {
        return new Ssd(
            _connectionType,
            _memoryCapacity,
            _speed,
            _power,
            _name);
    }

    public ISsdBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public ISsdBuilder SetConnectionType(string connectionType)
    {
        _connectionType = connectionType;
        return this;
    }

    public ISsdBuilder SetMemoryCapacity(int memoryCapacity)
    {
        _memoryCapacity = memoryCapacity;
        return this;
    }

    public ISsdBuilder SetSpeed(int speed)
    {
        _speed = speed;
        return this;
    }

    public ISsdBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }
}