namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public interface IShipDeflectors : IDamageable
{
    public bool AntiMatterFlashCrewAlive(int damage);
}