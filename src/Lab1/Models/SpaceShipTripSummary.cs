namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class SpaceShipTripSummary
{
    public bool Successful { get; private set; }
    public double RegularFuelSpent { get; private set; }
    public double JumpFuelSpent { get; private set; }
    public double TimeSpent { get; private set; }

    public void AddRegularFuelSpent(SectorTripResult sectorTripResult)
    {
        Successful = sectorTripResult.TripSuccessful;
        RegularFuelSpent += sectorTripResult.FuelSpent;
        TimeSpent += sectorTripResult.TimeSpent;
    }

    public void AddJumpFuelSpent(SectorTripResult sectorTripResult)
    {
        Successful = sectorTripResult.TripSuccessful;
        JumpFuelSpent += sectorTripResult.FuelSpent;
        TimeSpent += sectorTripResult.TimeSpent;
    }
}