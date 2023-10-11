using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Vaklas : SpaceShipWithDeflectors
{
    public Vaklas()
        : base(
            HullType.TypeTwo,
            DeflectorTypes.TypeThree,
            new ImpulseEngineE(),
            WeightCategories.WeightClassMedium,
            new GammaJumpDrive())
    {
    }
}