using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class Meteorite : IRegularSpaceObject
{
    private const double BaseDamage = 2;

    public Meteorite(int numberOfObjects, Dictionary<int, DamageAdjustment>? damageMappings = null)
    {
        DamagePointsLeft = numberOfObjects * BaseDamage;
        if (damageMappings is null)
        {
            DamageMappings = new Dictionary<int, DamageAdjustment>
            {
                { DeflectorsTypeOne.Id, new DamageAdjustment(true, 1) },
                { DeflectorsTypeTwo.Id, new DamageAdjustment(true, 5) },
                { DeflectorsTypeThree.Id, new DamageAdjustment(true, 2) },
                { ShipHullTypeOne.Id, new DamageAdjustment(true, 1) },
                { ShipHullTypeTwo.Id, new DamageAdjustment(true, 2.5) },
                { ShipHullTypeThree.Id, new DamageAdjustment(true, 2) },
                { PhotonDeflectors.Id, new DamageAdjustment(false) },
                { AntiNeutrinoEmitter.Id, new DamageAdjustment(false) },
            };
        }
        else
        {
            DamageMappings = damageMappings;
        }
    }

    public RouteCompletionResult CollisionResult => DamagePointsLeft <= 0 ?
        RouteCompletionResult.Success : RouteCompletionResult.ShipDestroyed;
    private double DamagePointsLeft { get; set; }
    private Dictionary<int, DamageAdjustment> DamageMappings { get; }

    public DamageEventResult GetDamage(int damageableId, double healthPoints)
    {
        if (DamagePointsLeft <= 0)
        {
            return new DamageEventResult();
        }

        if (!DamageMappings[damageableId].CanBeDamaged)
        {
            return new DamageEventResult(DamageMappings[damageableId].CanBeDamaged);
        }

        double startHealth = DamagePointsLeft;
        DamagePointsLeft -= healthPoints / DamageMappings[damageableId].DamageCoefficient;
        return new DamageEventResult(
            true,
            double.Min(
                DamageMappings[damageableId].DamageCoefficient * (startHealth - DamagePointsLeft),
                DamageMappings[damageableId].DamageCoefficient * startHealth));
    }
}