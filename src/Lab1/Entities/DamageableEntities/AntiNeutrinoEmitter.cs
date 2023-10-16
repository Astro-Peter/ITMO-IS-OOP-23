using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class AntiNeutrinoEmitter : Damageable
{
    public AntiNeutrinoEmitter()
        : base(0, Id)
    {
    }

    public static int Id => 7;
}