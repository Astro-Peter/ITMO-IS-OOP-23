using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class TripShuttle : ISpaceShip
{
    private SpaceShipHull ShipHull { get; } = new(HullType.TypeOne);
    private ImpulseEngineC Engine { get; } = new();

    public JourneyEngineInfo TraverseRegularEnvironment(double distance, bool hindered = false)
    {
        return Engine.TraverseChannel(distance, WeightCategories.WeightClassLight, hindered);
    }

    public JumpResult UseJumpDrive(double distance)
    {
        return new JumpResult(false, 0);
    }

    public DamageEventResult DamageShip(int damage, int numberOfHits)
    {
        return ShipHull.GetDamaged(damage);
    }

    public bool AntiMatterFlash(int power)
    {
        return false;
    }

    public bool WhaleCollision(int numberOfHits)
    {
        return false;
    }
}