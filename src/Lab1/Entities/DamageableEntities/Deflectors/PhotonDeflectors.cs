using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;

public class PhotonDeflectors : IPhotonDeflectors
{
    private const double Health = 3;

    public PhotonDeflectors()
    {
        Damageable = new Damageable(Health);
    }

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