﻿using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetCoolingSystem<out T>
{
    public T SetCoolingSystem(CoolingSystem coolingSystem);
}