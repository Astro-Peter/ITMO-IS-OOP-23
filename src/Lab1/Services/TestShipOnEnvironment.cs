using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class TestShipOnEnvironment
{
    public TestShipOnEnvironment(ISpaceSector[] spaceSectors, ISpaceShip[]? spaceShips = null)
    {
        SpaceShips = spaceShips;
        SpaceSectors = spaceSectors;
    }

    private ISpaceSector[] SpaceSectors { get; }
    private ISpaceShip[]? SpaceShips { get; }

    public SpaceShipTripSummary TestShipOnRoute(ISpaceShip spaceShip)
    {
        var spaceShipTripSummary = new SpaceShipTripSummary(RouteCompletionResult.Success);
        foreach (ISpaceSector spaceSector in SpaceSectors)
        {
            SpaceShipTripSummary sectorTravelResult = spaceSector.TraverseSector(spaceShip);
            if (sectorTravelResult.Result != RouteCompletionResult.Success)
            {
                return sectorTravelResult;
            }

            spaceShipTripSummary.Add(sectorTravelResult);
        }

        return spaceShipTripSummary;
    }

    public ISpaceShip? SelectOptimalShip()
    {
        if (SpaceShips == null)
        {
            throw new MissingMemberException(nameof(SpaceShips));
        }

        ISpaceShip? bestPossibleShip = null;
        var bestRun = new SpaceShipTripSummary();
        foreach (ISpaceShip spaceShip in SpaceShips)
        {
            ISpaceShip copySpaceShip = spaceShip.Copy();
            SpaceShipTripSummary result = TestShipOnRoute(copySpaceShip);
            if (bestRun.ChooseBest(result))
            {
                bestPossibleShip = spaceShip;
            }
        }

        return bestPossibleShip;
    }
}