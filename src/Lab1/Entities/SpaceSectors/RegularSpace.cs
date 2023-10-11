using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public class RegularSpace : ISpaceSector
{
    public RegularSpace(double distance, int numberOfAsteroids = 0, int numberOfMeteorites = 0)
    {
        NumberOfAsteroids = numberOfAsteroids;
        NumberOfMeteorites = numberOfMeteorites;
        Distance = distance;
    }

    private int NumberOfAsteroids { get; }
    private int NumberOfMeteorites { get; }
    private double Distance { get; }

    public SectorTripResult TraverseSector(ISpaceShip spaceShip)
    {
        DamageEventResult collisionResultFirst = spaceShip.DamageShip(SpaceObjects.Asteroid, NumberOfAsteroids);
        if (collisionResultFirst.Result == CollisionResult.Destroyed)
        {
            return new SectorTripResult(false, 0, 0);
        }

        DamageEventResult collisionResultSecond = spaceShip.DamageShip(SpaceObjects.Meteorite, NumberOfMeteorites);
        if (collisionResultSecond.Result == CollisionResult.Destroyed)
        {
            return new SectorTripResult(false, 0, 0);
        }

        JourneyEngineInfo tripResult = spaceShip.TraverseRegularEnvironment(Distance);
        return new SectorTripResult(true, tripResult);
    }
}