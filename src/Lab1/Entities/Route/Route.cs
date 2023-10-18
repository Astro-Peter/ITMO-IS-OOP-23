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

    private IList<ISpaceSector> Sectors { get; }

    public ITripInfo Travel(ISpaceShip ship)
    {
        ITripInfo? tripSummary = null;
        foreach (ISpaceSector sector in Sectors)
        {
            ITripInfo sectorTravelResult = sector.TraverseSector(ship);

            if (sectorTravelResult.Result == RouteCompletionResult.Success)
            {
                tripSummary = tripSummary?.Add(sectorTravelResult) ?? sectorTravelResult;
            }
            else
            {
                return sectorTravelResult;
            }
        }

        return tripSummary ?? new SpaceShipTripSummary(RouteCompletionResult.ShipLost);
    }
}