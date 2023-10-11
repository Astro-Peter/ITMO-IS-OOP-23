using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : SpaceShipWithDeflectors
{
    public Stella(bool hasPhotonDeflectors)
        : base(
            HullType.TypeOne,
            DeflectorTypes.TypeOne,
            hasPhotonDeflectors,
            new ImpulseEngineE(),
            WeightCategories.WeightClassLight,
            new OmegaJumpDrive())
    {
        HasPhotonDeflectors = hasPhotonDeflectors;
    }

    private bool HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Stella(HasPhotonDeflectors);
    }
}