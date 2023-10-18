namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;

public class DeflectorsTypeOne : BaseDeflectors
{
    private const int BaseHealth = 2;

    public DeflectorsTypeOne(IPhotonDeflectors? photonDeflectors = null)
        : base(
            BaseHealth,
            photonDeflectors)
    {
    }
}