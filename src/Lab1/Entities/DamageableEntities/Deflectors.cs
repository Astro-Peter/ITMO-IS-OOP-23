namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class Deflectors : DamageableComponent
{
    public Deflectors(int health, bool hasPhotonDeflectors)
        : base(health)
    {
        PhotonDeflectors = hasPhotonDeflectors ? 3 : 0;
    }

    private int PhotonDeflectors { get; set; }

    public bool AntiMatterFlashCrewAlive(int damage)
    {
        if (PhotonDeflectors >= damage)
        {
            PhotonDeflectors -= damage;
            return true;
        }

        PhotonDeflectors = 0;
        return false;
    }
}