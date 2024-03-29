﻿using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuiltInGpuBuilder;

public interface IBuiltInGpuBuilder : IBaseBuilder<BuiltInGpu>
{
    public IBuiltInGpuBuilder SetName(string name);
    public IBuiltInGpuBuilder SetFrequency(double frequency);
}