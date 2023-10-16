namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class DeflectorsTypeOne : BaseDeflectors
{
    private const int BaseHealth = 2;

    public DeflectorsTypeOne(IPhotonDeflectors? photonDeflectors = null)
        : base(
            BaseHealth,
            Id,
            photonDeflectors)
    {
    }

    public static int Id => 0;
}