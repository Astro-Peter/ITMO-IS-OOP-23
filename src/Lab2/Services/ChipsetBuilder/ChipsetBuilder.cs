using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;

public class ChipsetBuilder : IChipsetBuilder
{
    private IList<double> _memoryFrequencies = new List<double>();
    private string _name = "empty";
    private bool _xmpSupport;

    public Chipset Build()
    {
        return new Chipset(
            _name,
            _memoryFrequencies,
            _xmpSupport);
    }

    public IChipsetBuilder SetAvailableMemoryFrequencies(IList<double> memoryFrequencies)
    {
        _memoryFrequencies = memoryFrequencies;
        return this;
    }

    public IChipsetBuilder SetXmpSupport(bool support)
    {
        _xmpSupport = support;
        return this;
    }

    public IChipsetBuilder SetName(string name)
    {
        _name = name;
        return this;
    }
}