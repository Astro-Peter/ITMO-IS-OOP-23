using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public class RegularSpace : ISpaceSector
{
    public RegularSpace(
        double distance,
        IList<IRegularSpaceObject>? objects = null)
    {
        Objects = objects ?? new List<IRegularSpaceObject>();
        Distance = distance;
    }

    private IList<IRegularSpaceObject> Objects { get; }
    private double Distance { get; }

    public ITripInfo TraverseSector(ISpaceShip spaceShip)
    {
        foreach (IRegularSpaceObject spaceObject in Objects)
        {
            ISpaceObject copySpaceObject = spaceObject.Copy();
            spaceShip.DamageShip(copySpaceObject);
            if (copySpaceObject.CollisionResult != RouteCompletionResult.Success)
            {
                return new SpaceShipTripSummary(copySpaceObject.CollisionResult);
            }
        }

        ITripInfo tripInfo = spaceShip.TraverseRegularEnvironment(new RegularSpaceAdjustment(Distance));
        return tripInfo;
    }
}