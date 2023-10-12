namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public interface ISpaceObject
{
    public int ClassOneDeflectorDamage { get; }
    public int ClassTwoDeflectorDamage { get; }
    public int ClassThreeDeflectorDamage { get; }
    public int ClassOneHullDamage { get; }
    public int ClassTwoHullDamage { get; }
    public int ClassThreeHullDamage { get; }
}