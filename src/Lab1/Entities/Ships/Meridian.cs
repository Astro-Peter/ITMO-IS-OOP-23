using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meridian : SpaceShipWithDeflectors
{
    public Meridian(bool hasPhotonDeflectors)
        : base(
            HullType.TypeTwo,
            DeflectorTypes.TypeTwo,
            hasPhotonDeflectors,
            new ImpulseEngineE(),
            WeightCategories.WeightClassMedium,
            null,
            true)
    {
        HasPhotonDeflectors = hasPhotonDeflectors;
    }

    private bool HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Meridian(HasPhotonDeflectors);
    }
}