namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class SectorTripResult
{
    public SectorTripResult(bool tripSuccessful, double fuelSpent, double timeSpent)
    {
        TripSuccessful = tripSuccessful;
        FuelSpent = fuelSpent;
        TimeSpent = timeSpent;
    }

    public SectorTripResult(bool tripSuccessful, JourneyEngineInfo journeyEngineInfo)
    {
        TripSuccessful = tripSuccessful;
        FuelSpent = journeyEngineInfo.FuelSpent;
        TimeSpent = journeyEngineInfo.TimeSpent;
    }

    public bool TripSuccessful { get; }
    public double FuelSpent { get; }
    public double TimeSpent { get; }
}