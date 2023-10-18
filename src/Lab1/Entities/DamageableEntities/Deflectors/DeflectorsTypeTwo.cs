namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;

public class DeflectorsTypeTwo : BaseDeflectors
{
    private const int BaseHealth = 30;

    public DeflectorsTypeTwo(IPhotonDeflectors? photonDeflectors = null)
        : base(
            BaseHealth,
            photonDeflectors)
    {
    }
}