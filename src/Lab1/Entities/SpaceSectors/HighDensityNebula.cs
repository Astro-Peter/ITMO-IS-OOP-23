using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public class HighDensityNebula : ISpaceSector
{
    public HighDensityNebula(
        double distance,
        IList<IObjectInHighDensityNebula>? objects = null)
    {
        Objects = objects ?? new List<IObjectInHighDensityNebula>();
        Distance = distance;
    }

    private IList<IObjectInHighDensityNebula> Objects { get; }
    private double Distance { get; }

    public ITripInfo TraverseSector(ISpaceShip spaceShip)
    {
        foreach (IObjectInHighDensityNebula spaceObject in Objects)
        {
            ISpaceObject copySpaceObject = spaceObject.Copy();
            spaceShip.DamageShip(copySpaceObject);
            if (copySpaceObject.CollisionResult != RouteCompletionResult.Success)
            {
                return new SpaceShipTripSummary(copySpaceObject.CollisionResult);
            }
        }

        ITripInfo tripInfo = spaceShip.UseJumpDrive(new HighDensitySpaceAdjustment(Distance));
        return tripInfo;
    }
}