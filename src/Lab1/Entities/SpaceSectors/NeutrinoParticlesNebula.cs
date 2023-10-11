using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public class NeutrinoParticlesNebula : ISpaceSector
{
    public NeutrinoParticlesNebula(double distance, int numberOfWhales)
    {
        Distance = distance;
        NumberOfWhales = numberOfWhales;
    }

    private double Distance { get; }
    private int NumberOfWhales { get; }

    public SectorTripResult TraverseSector(ISpaceShip spaceShip)
    {
        bool whaleCollisionResult = spaceShip.WhaleCollision(NumberOfWhales);
        if (!whaleCollisionResult)
        {
            return new SectorTripResult(false, 0, 0);
        }

        return new SectorTripResult(true, spaceShip.TraverseRegularEnvironment(Distance, true));
    }
}