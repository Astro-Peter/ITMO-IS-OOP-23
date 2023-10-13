using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public class ImpulseEngineC : IImpulseEngine
{
    private static double FlightSpeed => 1;

    public SpaceShipTripSummary TraverseChannel(double distance, int weight, bool hindered = false)
    {
        double timeSpent = distance / FlightSpeed;
        if (hindered)
        {
            timeSpent *= ImpulseEngineConstants.HinderedEffect;
        }

        return new SpaceShipTripSummary(RouteCompletionResult.Success, (timeSpent * weight) + ImpulseEngineConstants.FuelStartupCost, 0, timeSpent);
    }
}