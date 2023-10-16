using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class BaseDeflectors : IShipDeflectors
{
    protected BaseDeflectors(int health, int id, IPhotonDeflectors? photonDeflectors = null)
    {
        PhotonDeflectors = photonDeflectors;
        Protection = new Damageable(health, id);
    }

    private IPhotonDeflectors? PhotonDeflectors { get; }
    private Damageable Protection { get; }

    public void GetDamaged(ISpaceObject spaceObject)
    {
        PhotonDeflectors?.GetDamaged(spaceObject);
        Protection.GetDamaged(spaceObject);
    }
}