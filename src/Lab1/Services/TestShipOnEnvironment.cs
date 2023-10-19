using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripComparison;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class TestShipOnEnvironment
{
    public TestShipOnEnvironment(
        IRoute route,
        ITripCompare compareTrips,
        ISpaceShip[]? spaceShips = null)
    {
        ComparisonFunction = compareTrips;
        Route = route;
        SpaceShips = spaceShips;
    }

    private IRoute Route { get; }
    private ISpaceShip[]? SpaceShips { get; }
    private ITripCompare ComparisonFunction { get; }

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
            if (ComparisonFunction.Compare(result, bestRun))
            {
                bestPossibleShip = spaceShip;
                bestRun = result;
            }
        }

        return bestPossibleShip;
    }
}