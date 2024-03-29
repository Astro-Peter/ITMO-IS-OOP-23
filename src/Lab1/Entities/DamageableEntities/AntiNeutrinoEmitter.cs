﻿using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class AntiNeutrinoEmitter : IProtectsFromWhales
{
    public AntiNeutrinoEmitter()
    {
    }

    public void GetDamaged(ISpaceObject spaceObject)
    {
        if (spaceObject.CheckIfDamageable(this))
        {
            spaceObject.GetDamaged(spaceObject.DamageLeft);
        }
    }
}