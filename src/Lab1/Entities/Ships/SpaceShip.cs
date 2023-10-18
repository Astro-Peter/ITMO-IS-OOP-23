using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class SpaceShip : ISpaceShip
{
    protected SpaceShip(
        IDamageable hull,
        IShipDeflectors? deflectorType,
        IImpulseEngine engine,
        IJumpDrive? jumpDrive = null)
    {
        Engine = engine;
        Hull = hull;
        Deflectors = deflectorType;
        JumpDrive = jumpDrive;
    }

    private IDamageable Hull { get; }
    private IShipDeflectors? Deflectors { get; }
    private IImpulseEngine Engine { get; }
    private IJumpDrive? JumpDrive { get; }

    public ITripInfo TraverseRegularEnvironment(IAdjustSpeed speedAdjustment)
    {
        return Engine.Travel(speedAdjustment);
    }

    public ITripInfo UseJumpDrive(IAdjustSpeed speedAdjustment)
    {
        return JumpDrive?.Travel(speedAdjustment) ?? new SpaceShipTripSummary(RouteCompletionResult.ShipLost);
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