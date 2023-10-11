using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Vaklas : SpaceShipWithDeflectors
{
    public Vaklas(bool hasPhotonDeflectors)
        : base(
            HullType.TypeTwo,
            DeflectorTypes.TypeThree,
            hasPhotonDeflectors,
            new ImpulseEngineE(),
            WeightCategories.WeightClassMedium,
            new GammaJumpDrive())
    {
        HasPhotonDeflectors = hasPhotonDeflectors;
    }

    private bool HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Vaklas(HasPhotonDeflectors);
    }
}