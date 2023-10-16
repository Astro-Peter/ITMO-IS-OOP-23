using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class PhotonDeflectors : IPhotonDeflectors
{
    private const double Health = 3;

    public PhotonDeflectors()
    {
        Damageable = new Damageable(Health, Id);
    }

    public static int Id => 6;
    private Damageable Damageable { get; }
    public void GetDamaged(ISpaceObject spaceObject)
    {
        Damageable.GetDamaged(spaceObject);
    }

    public IPhotonDeflectors Copy()
    {
        return new PhotonDeflectors();
    }
}