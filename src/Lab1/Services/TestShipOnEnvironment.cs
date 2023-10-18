using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class TestShipOnEnvironment
{
    public TestShipOnEnvironment(
        IRoute route,
        IFuelMarket market,
        Func<ITripInfo, ITripInfo, IFuelMarket, bool> comparisonFunction,
        ISpaceShip[]? spaceShips = null)
    {
        ComparisonFunction = comparisonFunction;
        Route = route;
        FuelMarket = market;
        SpaceShips = spaceShips;
    }

    private IRoute Route { get; }
    private IFuelMarket FuelMarket { get; }
    private ISpaceShip[]? SpaceShips { get; }
    private Func<ITripInfo, ITripInfo, IFuelMarket, bool> ComparisonFunction { get; }

    public ISpaceShip? SelectOptimalShip()
    {
        if (SpaceShips == null)
        {
            throw new MissingMemberException(nameof(SpaceShips));
        }

        ISpaceShip? bestPossibleShip = null;
        ITripInfo bestRun = new SpaceShipTripSummary();
        foreach (ISpaceShip spaceShip in SpaceShips)
        {
            ISpaceShip copySpaceShip = spaceShip.Copy();
            ITripInfo result = Route.Travel(copySpaceShip);
            if (ComparisonFunction(result, bestRun, FuelMarket))
            {
                bestPossibleShip = spaceShip;
                bestRun = result;
            }
        }

        return bestPossibleShip;
    }
}