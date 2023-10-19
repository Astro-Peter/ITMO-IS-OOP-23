using Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.TripComparison;

public class TripCompare : ITripCompare
{
    public TripCompare(IFuelMarket fuelMarket)
    {
        FuelMarket = fuelMarket;
    }

    private IFuelMarket FuelMarket { get; }

    public bool Compare(ITripInfo first, ITripInfo second)
    {
        if (second.Result != RouteCompletionResult.Success)
        {
            return true;
        }

        if (first.Result != RouteCompletionResult.Success)
        {
            return false;
        }

        return FuelMarket.GetTotalCost(first.GetFuelSpent())
               < FuelMarket.GetTotalCost(second.GetFuelSpent());
    }
}