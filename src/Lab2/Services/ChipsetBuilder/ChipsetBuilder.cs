using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ChipsetBuilder;

public class ChipsetBuilder : IChipsetBuilder
{
    private string? Name { get; set; }
    private IList<double>? MemoryFrequencies { get; set; }
    private bool? XmpSupport { get; set; }
    public Chipset Build()
    {
        return new Chipset(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            MemoryFrequencies ?? throw new UndefinedParameterException(nameof(MemoryFrequencies)),
            XmpSupport ?? throw new UndefinedParameterException(nameof(XmpSupport)));
    }

    public IChipsetBuilder SetAvailableMemoryFrequencies(IList<double> memoryFrequencies)
    {
        MemoryFrequencies = memoryFrequencies;
        return this;
    }

    public IChipsetBuilder SetXmpSupport(bool support)
    {
        XmpSupport = support;
        return this;
    }

    public IChipsetBuilder SetName(string name)
    {
        Name = name;
        return this;
    }
}