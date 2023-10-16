using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;

public class Route : IRoute
{
    public Route(IList<ISpaceSector> sectors)
    {
        Sectors = sectors;
    }

    public IList<ISpaceSector> Sectors { get; }

    public ITripInfo Travel(ISpaceShip ship)
    {
        var tripSummary = new SpaceShipTripSummary();
        foreach (ISpaceSector sector in Sectors)
        {
            SpaceShipTripSummary sectorTravelResult = sector.TraverseSector(ship);

            if (sectorTravelResult.Result == RouteCompletionResult.Success)
            {
                tripSummary = tripSummary.Add(sectorTravelResult);
            }
            else
            {
                return sectorTravelResult;
            }
        }

        return tripSummary;
    }
}