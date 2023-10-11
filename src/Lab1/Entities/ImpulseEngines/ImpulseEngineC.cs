using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public class ImpulseEngineC : IImpulseEngine
{
    private static double FlightSpeed => 1;
    private static double FuelConsumptionRate => 1;

    public JourneyEngineInfo TraverseChannel(double distance, int weight, bool hindered = false)
    {
        double timeSpent = distance / FlightSpeed;
        if (hindered)
        {
            timeSpent *= 100;
        }

        double fuelSpent = timeSpent * weight * FuelConsumptionRate;
        return new JourneyEngineInfo(timeSpent, fuelSpent);
    }
}