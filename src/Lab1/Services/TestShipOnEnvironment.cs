using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class TestShipOnEnvironment
{
    public TestShipOnEnvironment(IRoute route, ISpaceShip[]? spaceShips = null)
    {
        Route = route;
        SpaceShips = spaceShips;
    }

    private IRoute Route { get; }
    private ISpaceShip[]? SpaceShips { get; }

    public ISpaceShip? SelectOptimalShip()
    {
        if (SpaceShips == null)
        {
            throw new MissingMemberException(nameof(SpaceShips));
        }

        ISpaceShip? bestPossibleShip = null;
        ITripInfo bestRun;
        foreach (ISpaceShip spaceShip in SpaceShips)
        {
            ISpaceShip copySpaceShip = spaceShip.Copy();
            ITripInfo result = Route.Travel(copySpaceShip);
            if (bestRun.ChooseBest(result))
            {
                bestPossibleShip = spaceShip;
            }
        }

        return bestPossibleShip;
    }
}