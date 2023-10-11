using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meridian : SpaceShipWithDeflectors
{
    public Meridian()
        : base(
            HullType.TypeTwo,
            DeflectorTypes.TypeTwo,
            new ImpulseEngineE(),
            WeightCategories.WeightClassMedium,
            null,
            true)
    {
    }
}