using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class AntiMatterFlash : IObjectInHighDensityNebula
{
    public AntiMatterFlash(Dictionary<int, DamageAdjustment>? damageMappings = null)
    {
        if (damageMappings is null)
        {
            DamageMappings = new Dictionary<int, DamageAdjustment>
            {
                { DeflectorsTypeOne.Id, new DamageAdjustment(false) },
                { DeflectorsTypeTwo.Id, new DamageAdjustment(false) },
                { DeflectorsTypeThree.Id, new DamageAdjustment(false) },
                { ShipHullTypeOne.Id, new DamageAdjustment(false) },
                { ShipHullTypeTwo.Id, new DamageAdjustment(false) },
                { ShipHullTypeThree.Id, new DamageAdjustment(false) },
                { PhotonDeflectors.Id, new DamageAdjustment(true, 1) },
                { AntiNeutrinoEmitter.Id, new DamageAdjustment(false) },
            };
        }
        else
        {
            DamageMappings = damageMappings;
        }
    }

    public RouteCompletionResult CollisionResult => DamagePointsLeft <= 0 ?
        RouteCompletionResult.Success : RouteCompletionResult.CrewLost;

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