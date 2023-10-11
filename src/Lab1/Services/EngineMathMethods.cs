using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public static class EngineMathMethods
{
    public static JourneyEngineInfo ConstantSpeedTraversal(double engineSpeed, double fuelConsumptionRate, double distance)
    {
        double timeSpent = distance / engineSpeed;
        double fuelSpent = fuelConsumptionRate * timeSpent;
        return new JourneyEngineInfo(timeSpent, fuelSpent);
    }

    public static JourneyEngineInfo ExponentialSpeedTraversal(double engineSpeed, double fuelConsumptionRate, double distance)
    {
        double timeSpent = Math.Log(Math.Log(engineSpeed) * distance, engineSpeed);
        double fuelSpent = timeSpent * Math.Pow(engineSpeed,);
        return new JourneyEngineInfo(0, 0);
    }

    public static JourneyEngineInfo LogarithmicSpeedTraversal(double fuelConsumptionRate, double distance)
    {
        return new JourneyEngineInfo(0, 0);
    }

    public static JourneyEngineInfo SquareSpeedTraversal(double fuelConsumptionRate, double distance)
    {
        double timeSpent = Math.Sqrt(distance);
        double
    }
}