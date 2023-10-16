using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class SpaceShipWithDeflectors : ISpaceShip
{
    protected SpaceShipWithDeflectors(
        IDamageable hull,
        IShipDeflectors? deflectorType,
        IImpulseEngine engine,
        int weightClass,
        IJumpDrive? jumpDrive = null)
    {
        WeightClass = weightClass;
        Engine = engine;
        Hull = hull;
        Deflectors = deflectorType;
        JumpDrive = jumpDrive;
    }

    private int WeightClass { get; }
    private IDamageable Hull { get; }
    private IShipDeflectors? Deflectors { get; }
    private IImpulseEngine Engine { get; }
    private IJumpDrive? JumpDrive { get; }

    public IImpulseEngine TraverseRegularEnvironment(double distance)
    {
        return Engine;
    }

    public IJumpDrive? UseJumpDrive(double distance)
    {
        return JumpDrive;
    }

    public void DamageShip(ISpaceObject spaceObject)
    {
        Deflectors?.GetDamaged(spaceObject);
        Hull.GetDamaged(spaceObject);
    }

    public virtual ISpaceShip Copy()
    {
        throw new NotImplementedException();
    }
}