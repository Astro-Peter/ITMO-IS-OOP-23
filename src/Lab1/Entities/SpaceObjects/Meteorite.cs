namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class Meteorite : ISpaceObject
{
    public int ClassOneDeflectorDamage { get; } = 2;
    public int ClassTwoDeflectorDamage { get; } = 10;
    public int ClassThreeDeflectorDamage { get; } = 4;
    public int ClassOneHullDamage { get; } = 2;
    public int ClassTwoHullDamage { get; } = 5;
    public int ClassThreeHullDamage { get; } = 4;
}