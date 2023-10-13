namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class SpaceShipTripSummary
{
    public SpaceShipTripSummary(
        RouteCompletionResult result = RouteCompletionResult.ShipDestroyed,
        double regularFuelSpent = 0,
        double jumpFuelSpent = 0,
        double timeSpent = 0)
    {
        Result = result;
        RegularFuelSpent = regularFuelSpent;
        JumpFuelSpent = jumpFuelSpent;
        TimeSpent = timeSpent;
    }

    public RouteCompletionResult Result { get; private set; }
    public double RegularFuelSpent { get; private set; }
    public double JumpFuelSpent { get; private set; }
    public double TimeSpent { get; private set; }

    public void Add(SpaceShipTripSummary summary)
    {
        RegularFuelSpent += summary.RegularFuelSpent;
        JumpFuelSpent += summary.JumpFuelSpent;
        TimeSpent += summary.TimeSpent;
    }

    public bool ChooseBest(SpaceShipTripSummary summary)
    {
        if (summary.Result != RouteCompletionResult.Success ||
            (Result == RouteCompletionResult.Success && FuelMarket.GetCost(summary) >= FuelMarket.GetCost(this))) return false;
        Result = summary.Result;
        JumpFuelSpent = summary.JumpFuelSpent;
        RegularFuelSpent = summary.RegularFuelSpent;
        TimeSpent = summary.TimeSpent;
        return true;
    }
}