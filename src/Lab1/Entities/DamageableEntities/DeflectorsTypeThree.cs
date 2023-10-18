﻿namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class DeflectorsTypeThree : BaseDeflectors
{
    private const int BaseHealth = 40;

    public DeflectorsTypeThree(IPhotonDeflectors? photonDeflectors)
        : base(
            BaseHealth,
            photonDeflectors)
    {
    }
}