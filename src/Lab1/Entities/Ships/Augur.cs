using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Augur : SpaceShipWithDeflectors
{
    public Augur()
        : base(
            HullType.TypeThree,
            DeflectorTypes.TypeThree,
            new ImpulseEngineE(),
            WeightCategories.WeightClassHeavy,
            new AlphaJumpDrive())
    {
    }
}