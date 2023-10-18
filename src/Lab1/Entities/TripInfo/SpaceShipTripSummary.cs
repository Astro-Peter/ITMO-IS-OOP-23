using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

public class SpaceShipTripSummary : ITripInfo
{
    public SpaceShipTripSummary(
        RouteCompletionResult result = RouteCompletionResult.ShipDestroyed,
        IDictionary<int, double>? fuelSpent = null,
        double timeSpent = 0)
    {
        Result = result;
        FuelSpent = fuelSpent ?? new Dictionary<int, double>();
        TimeSpent = timeSpent;
    }

    public SpaceShipTripSummary(
        RouteCompletionResult result,
        int id,
        double fuel,
        double timeSpent = 0)
    {
        Result = result;
        FuelSpent = new Dictionary<int, double>()
        {
            { id, fuel },
        };
        TimeSpent = timeSpent;
    }

    public RouteCompletionResult Result { get; }
    public double TimeSpent { get; }
    private IDictionary<int, double> FuelSpent { get; }

    public IDictionary<int, double> GetFuelSpent()
    {
        return FuelSpent;
    }

    public ITripInfo Add(ITripInfo summary)
    {
        IDictionary<int, double> otherFuel = summary.GetFuelSpent();
        IDictionary<int, double> mainFuel = new Dictionary<int, double>(FuelSpent);
        foreach (KeyValuePair<int, double> fuel in otherFuel)
        {
            if (mainFuel.ContainsKey(fuel.Key))
            {
                mainFuel[fuel.Key] += fuel.Value;
            }
            else
            {
                mainFuel.Add(fuel);
            }
        }

        return new SpaceShipTripSummary(
            RouteCompletionResult.Success,
            mainFuel,
            summary.TimeSpent + TimeSpent);
    }
}