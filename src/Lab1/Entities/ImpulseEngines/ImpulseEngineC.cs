using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class ImpulseEngineC : IImpulseEngine
{
    public double FlightSpeed => 1;
    public double FuelConsumptionRate => 1;
    public JourneyInfo JourneyInfo { get; private set; }

    public JourneyInfo Traverse(double unitsOfSpace)
    {

    }
}