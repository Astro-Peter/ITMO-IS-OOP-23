using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class SpaceShipWithDeflectors : ISpaceShip
{
    protected SpaceShipWithDeflectors(
        int hullType,
        int deflectorType,
        IImpulseEngine engine,
        int weightClass,
        IJumpDrive? jumpDrive = null,
        bool antiNeutrino = false)
    {
        WeightClass = weightClass;
        Engine = engine;
        Hull = new SpaceShipHull(hullType);
        Deflectors = new Deflectors(deflectorType, antiNeutrino);
        DeflectorsOnline = true;
        AntiNeutrino = antiNeutrino;
        JumpDrive = jumpDrive;
    }

    private int WeightClass { get; }
    private SpaceShipHull Hull { get; }
    private Deflectors Deflectors { get; }
    private IImpulseEngine Engine { get; }
    private bool DeflectorsOnline { get; set; }
    private bool AntiNeutrino { get; }
    private IJumpDrive? JumpDrive { get; }

    public JourneyEngineInfo TraverseRegularEnvironment(double distance, bool hindered = false)
    {
        return Engine.TraverseChannel(distance, WeightClass, hindered);
    }

    public JumpResult UseJumpDrive(double distance)
    {
        return JumpDrive is null ? new JumpResult(false, 0) : JumpDrive.Traverse(distance);
    }

    public bool DamageShip(int damage, int numberOfHits)
    {
        int cnt = 0;
        var damageEventResult = new DamageEventResult(CollisionResult.Operational, 0);
        if (DeflectorsOnline)
        {
            for (; cnt < numberOfHits && DeflectorsOnline; cnt++)
            {
                damageEventResult = Deflectors.GetDamaged(damage);
                DeflectorsOnline = damageEventResult.Result == CollisionResult.Disabled;
            }
        }

        damageEventResult = Hull.GetDamaged(damageEventResult.DamagePointsLeft);
        for (; cnt < numberOfHits && damageEventResult.Result != CollisionResult.Destroyed; cnt++)
        {
            damageEventResult = Hull.GetDamaged(damage);
        }

        return damageEventResult.Result != CollisionResult.Destroyed;
    }

    public bool AntiMatterFlash(int power)
    {
        return Deflectors.AntiMatterFlashCrewAlive(power);
    }

    public bool WhaleCollision(int numberOfHits)
    {
        return AntiNeutrino || DamageShip(SpaceObjects.CosmoWhale, numberOfHits);
    }
}