using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class DeflectorsTypeOne : IShipDeflectors
{
    public DeflectorsTypeOne(bool photonDeflectors)
    {
        Health = 2;
        PhotonDeflectors = photonDeflectors ? 3 : 0;
    }

    private int Health { get; set; }
    private int PhotonDeflectors { get; set; }

    public DamageEventResult GetDamaged(ISpaceObject spaceObject, int collisionNumber)
    {
        Health -= spaceObject.ClassOneDeflectorDamage * collisionNumber;
        if (Health >= 0) return new DamageEventResult();
        int healthOverflow = -Health;
        Health = 0;
        return new DamageEventResult(false, healthOverflow);
    }

    public DamageEventResult AbsorbDamageOverflow(int damage)
    {
        Health -= damage;
        if (Health >= 0) return new DamageEventResult();
        int healthOverflow = -Health;
        Health = 0;
        return new DamageEventResult(false, healthOverflow);
    }

    public bool AntiMatterFlashCrewAlive(int damage)
    {
        if (PhotonDeflectors < damage) return false;
        PhotonDeflectors -= damage;
        return true;
    }
}