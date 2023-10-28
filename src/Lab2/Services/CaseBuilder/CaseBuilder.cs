using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CaseBuilder;

public class CaseBuilder : ICaseBuilder
{
    private Dimensions _dimensions = new(0, 0, 0);
    private Dimensions _maximumGpuDimensions = new(0, 0, 0);
    private MotherBoardFormFactor _motherBoardFormFactor = MotherBoardFormFactor.None;
    private string _name = "empty";

    public PcCase Build()
    {
        return new PcCase(
            _dimensions,
            _motherBoardFormFactor,
            _maximumGpuDimensions,
            _name);
    }

    public ICaseBuilder SetDimensions(Dimensions dimensions)
    {
        _dimensions = dimensions;
        return this;
    }

    public ICaseBuilder SetMaximumGpuDimensions(Dimensions dimensions)
    {
        _maximumGpuDimensions = dimensions;
        return this;
    }

    public ICaseBuilder SetMotherboardFormFactor(MotherBoardFormFactor formFactor)
    {
        _motherBoardFormFactor = formFactor;
        return this;
    }

    public ICaseBuilder SetName(string name)
    {
        _name = name;
        return this;
    }
}