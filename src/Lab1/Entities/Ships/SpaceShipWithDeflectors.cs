using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class SpaceShipWithDeflectors : ISpaceShip
{
    protected SpaceShipWithDeflectors(
        string name,
        IShipHull hull,
        IShipDeflectors deflectorType,
        IImpulseEngine engine,
        int weightClass,
        IJumpDrive? jumpDrive = null,
        bool antiNeutrino = false)
    {
        Name = name;
        WeightClass = weightClass;
        Engine = engine;
        Hull = hull;
        Deflectors = deflectorType;
        DeflectorsOnline = true;
        AntiNeutrino = antiNeutrino;
        JumpDrive = jumpDrive;
    }

    private int WeightClass { get; }
    private IShipHull Hull { get; }
    private IShipDeflectors Deflectors { get; }
    private IImpulseEngine Engine { get; }
    private bool DeflectorsOnline { get; set; }
    private bool AntiNeutrino { get; }
    private IJumpDrive? JumpDrive { get; }
    private string Name { get; }

    public SpaceShipTripSummary TraverseRegularEnvironment(double distance, bool hindered = false)
    {
        return Engine.TraverseChannel(distance, WeightClass, hindered);
    }

    public SpaceShipTripSummary UseJumpDrive(double distance)
    {
        return JumpDrive is null
            ? new SpaceShipTripSummary(RouteCompletionResult.CrewLost)
            : JumpDrive.Traverse(distance);
    }

    public bool DamageShip(ISpaceObject spaceObject, int numberOfHits)
    {
        DamageEventResult damageEventResult = Deflectors.GetDamaged(spaceObject, numberOfHits);
        Hull.AbsorbDamageOverflow(damageEventResult.DamagePointsLeft);
        damageEventResult = Hull.GetDamaged(spaceObject, numberOfHits);
        return damageEventResult.Operational;
    }

    public bool AntiMatterFlash(int power)
    {
        return Deflectors.AntiMatterFlashCrewAlive(power);
    }

    public bool WhaleCollision(int numberOfHits)
    {
        return AntiNeutrino || DamageShip(new SpaceWhale(), numberOfHits);
    }

    public virtual ISpaceShip Copy()
    {
        throw new NotImplementedException();
    }

    public string GetName()
    {
        return Name;
    }
}