using System;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuiltInGpuBuilder;

public class BuiltInGpuBuilder : IBuiltInGpuBuilder
{
    private string _name = "empty";
    private double _frequency;
    public BuiltInGpu Build()
    {
        return new BuiltInGpu(
            _name,
            _frequency);
    }

    public IBuiltInGpuBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IBuiltInGpuBuilder SetFrequency(double frequency)
    {
        _frequency = frequency;
        return this;
    }
}