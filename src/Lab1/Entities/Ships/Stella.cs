using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : SpaceShipWithDeflectors
{
    public Stella()
        : base(
            HullType.TypeOne,
            DeflectorTypes.TypeOne,
            new ImpulseEngineE(),
            WeightCategories.WeightClassLight,
            new OmegaJumpDrive())
    {
    }
}