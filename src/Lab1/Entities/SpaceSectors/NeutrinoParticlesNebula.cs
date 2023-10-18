using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public class NeutrinoParticlesNebula : ISpaceSector
{
    public NeutrinoParticlesNebula(
        double distance,
        IList<IObjectInNeutrinoParticlesNebula>? objects = null)
    {
        Objects = objects ?? new List<IObjectInNeutrinoParticlesNebula>();
        Distance = distance;
    }

    private IList<IObjectInNeutrinoParticlesNebula> Objects { get; }
    private double Distance { get; }

    public ITripInfo TraverseSector(ISpaceShip spaceShip)
    {
        foreach (IObjectInNeutrinoParticlesNebula spaceObject in Objects)
        {
            ISpaceObject copySpaceObject = spaceObject.Copy();
            spaceShip.DamageShip(copySpaceObject);
            if (copySpaceObject.CollisionResult != RouteCompletionResult.Success)
            {
                return new SpaceShipTripSummary(copySpaceObject.CollisionResult);
            }
        }

        ITripInfo tripInfo = spaceShip.TraverseRegularEnvironment(new NeutrinoParticlesAdjustment(Distance));
        return tripInfo;
    }
}