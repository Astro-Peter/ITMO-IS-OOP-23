using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public interface IImpulseEngine
{
    public double FlightSpeed { get; }
    public double FuelConsumptionRate { get; }
    public JumpResult TraverseChannel(double distance);
}