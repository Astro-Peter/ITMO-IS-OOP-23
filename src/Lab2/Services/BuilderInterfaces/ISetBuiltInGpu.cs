﻿using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetBuiltInGpu<out T>
{
    public T SetBuiltInGpu(BuiltInGpu gpu);
}