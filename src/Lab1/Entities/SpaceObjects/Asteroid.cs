namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class Asteroid : ISpaceObject
{
    public int ClassOneDeflectorDamage { get; } = 1;
    public int ClassTwoDeflectorDamage { get; } = 3;
    public int ClassThreeDeflectorDamage { get; } = 1;
    public int ClassOneHullDamage { get; } = 1;
    public int ClassTwoHullDamage { get; } = 2;
    public int ClassThreeHullDamage { get; } = 1;
}