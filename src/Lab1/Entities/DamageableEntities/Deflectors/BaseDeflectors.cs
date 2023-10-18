using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;

public class BaseDeflectors : IShipDeflectors
{
    protected BaseDeflectors(int health, IPhotonDeflectors? photonDeflectors = null)
    {
        PhotonDeflectors = photonDeflectors;
        Protection = new Damageable(health);
    }

    private IPhotonDeflectors? PhotonDeflectors { get; }
    private Damageable Protection { get; }

    public void GetDamaged(ISpaceObject spaceObject)
    {
        PhotonDeflectors?.GetDamaged(spaceObject);
        if (spaceObject.CheckIfDamageable(this))
        {
            Protection.GetDamaged(spaceObject);
        }
    }
}