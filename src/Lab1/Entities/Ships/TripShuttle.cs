using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class TripShuttle : ISpaceShip
{
    private IShipHull ShipHull { get; } = new ShipHullTypeOne();
    private ImpulseEngineC Engine { get; } = new();

    public SpaceShipTripSummary TraverseRegularEnvironment(double distance, bool hindered = false)
    {
        return Engine.TraverseChannel(distance, WeightCategories.WeightClassLight, hindered);
    }

    public SpaceShipTripSummary UseJumpDrive(double distance)
    {
        return new SpaceShipTripSummary(RouteCompletionResult.ShipLost);
    }

    public bool DamageShip(ISpaceObject spaceObject, int numberOfHits)
    {
        return ShipHull.GetDamaged(spaceObject, numberOfHits).Operational;
    }

    public bool AntiMatterFlash(int power)
    {
        return power == 0;
    }

    public bool WhaleCollision(int numberOfHits)
    {
        return ShipHull.GetDamaged(new SpaceWhale(), numberOfHits).Operational;
    }

    public ISpaceShip Copy()
    {
        return new TripShuttle();
    }

    public string GetName()
    {
        return "TripShuttle";
    }
}