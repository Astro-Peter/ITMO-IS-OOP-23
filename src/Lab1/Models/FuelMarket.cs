namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public static class FuelMarket
{
    private static int ImpulseFuelCost => 10;
    private static int JumpFuelCost => 40;

    public static double GetCost(SpaceShipTripSummary tripSummary)
    {
        return (tripSummary.JumpFuelSpent * JumpFuelCost) + (tripSummary.RegularFuelSpent * ImpulseFuelCost);
    }
}