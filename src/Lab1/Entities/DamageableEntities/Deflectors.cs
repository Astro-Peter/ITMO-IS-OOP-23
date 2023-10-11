using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Deflectors : DamageableComponent
{
    public Deflectors(DeflectorTypes type, bool hasPhotonDeflectors)
        : base((int)type)
    {
        PhotonDeflectors = hasPhotonDeflectors ? 3 : 0;
    }

    private int PhotonDeflectors { get; set; }

    public CollisionResult AntiMatterFlashed()
    {
        if (PhotonDeflectors > 0)
        {
            PhotonDeflectors--;
            return CollisionResult.Operational;
        }

        return CollisionResult.Destroyed;
    }
}