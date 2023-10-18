using Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public static class CompareTripInfos
{
    public static bool Better(ITripInfo a, ITripInfo b, IFuelMarket market)
    {
        if (b.Result != RouteCompletionResult.Success)
        {
            return true;
        }

        if (a.Result != RouteCompletionResult.Success)
        {
            return false;
        }

        return market.GetTotalCost(a.GetFuelSpent())
               < market.GetTotalCost(b.GetFuelSpent());
    }
}