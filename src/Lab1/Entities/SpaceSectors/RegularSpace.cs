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

    public SpaceShipTripSummary TraverseSector(ISpaceShip spaceShip)
    {
        bool collisionResultFirst = spaceShip.DamageShip(SpaceObjects.Asteroid, NumberOfAsteroids);
        if (!collisionResultFirst)
        {
            return new SpaceShipTripSummary(RouteCompletionResult.ShipDestroyed);
        }

        bool collisionResultSecond = spaceShip.DamageShip(SpaceObjects.Meteorite, NumberOfMeteorites);
        if (!collisionResultSecond)
        {
            return new SpaceShipTripSummary(RouteCompletionResult.ShipDestroyed);
        }

        return spaceShip.TraverseRegularEnvironment(Distance);
    }
}