using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class ImpulseEngineE : IImpulseEngine
{
    public double FlightSpeed => 0.05;
    public double FuelConsumptionRate => 1;
    public JourneyInfo JourneyInfo;

    public JourneyInfo Traverse(double unitsOfSpace)
    {
        System.Math.Log(FlightSpeed);
    }
}