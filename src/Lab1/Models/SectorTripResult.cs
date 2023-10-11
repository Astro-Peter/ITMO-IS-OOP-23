namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class SectorTripResult
{
    public SectorTripResult(RouteCompletionResult tripSuccessful, double fuelSpent, double timeSpent)
    {
        TripSuccessful = tripSuccessful;
        FuelSpent = fuelSpent;
        TimeSpent = timeSpent;
    }

    public SectorTripResult(RouteCompletionResult tripSuccessful, JourneyEngineInfo journeyEngineInfo)
    {
        TripSuccessful = tripSuccessful;
        FuelSpent = journeyEngineInfo.FuelSpent;
        TimeSpent = journeyEngineInfo.TimeSpent;
    }

    public SectorTripResult(JumpResult jumpResult)
    {
        TripSuccessful = jumpResult.Completed;
        FuelSpent = jumpResult.FuelSpent;
        TimeSpent = jumpResult.FuelSpent / 10;
    }

    public RouteCompletionResult TripSuccessful { get; }
    public double FuelSpent { get; }
    public double TimeSpent { get; }
}