﻿namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeTwo : ShipHull
{
    private const int Health = 10;

    public ShipHullTypeTwo()
        : base(Health)
    {
    }
}