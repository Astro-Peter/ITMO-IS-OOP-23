using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public class ImpulseEngineE : IImpulseEngine
{
    private static double FlightSpeed => 2;
    private static double FuelConsumptionRate => 10;

    public JourneyEngineInfo TraverseChannel(double distance, int weight, bool hindered = false)
    {
        double timeSpent = Math.Log(Math.Log(FlightSpeed) * distance, FlightSpeed);
        return new JourneyEngineInfo(timeSpent, timeSpent * weight * FuelConsumptionRate);
    }
}