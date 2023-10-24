using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CaseBuilder;

public class CaseBuilder : ICaseBuilder
{
    private string? Name { get; set; }
    private Dimensions? Dimensions { get; set; }
    private Dimensions? MaximumGpuDimensions { get; set; }
    private MotherBoardFormFactor? MotherBoardFormFactor { get; set; }

    public PcCase Build()
    {
        return new PcCase(
            Dimensions ?? throw new UndefinedParameterException(nameof(Dimensions)),
            MotherBoardFormFactor ?? throw new UndefinedParameterException(nameof(MotherBoardFormFactor)),
            MaximumGpuDimensions ?? throw new UndefinedParameterException(nameof(MaximumGpuDimensions)),
            Name ?? throw new UndefinedParameterException(nameof(Name)));
    }

    public ICaseBuilder SetDimensions(Dimensions dimensions)
    {
        Dimensions = dimensions;
        return this;
    }

    public ICaseBuilder SetMaximumGpuDimensions(Dimensions dimensions)
    {
        MaximumGpuDimensions = dimensions;
        return this;
    }

    public ICaseBuilder SetMotherboardFormFactor(MotherBoardFormFactor formFactor)
    {
        MotherBoardFormFactor = formFactor;
        return this;
    }

    public ICaseBuilder SetName(string name)
    {
        Name = name;
        return this;
    }
}