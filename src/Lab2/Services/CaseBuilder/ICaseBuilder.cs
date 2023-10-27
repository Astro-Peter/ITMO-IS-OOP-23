using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CaseBuilder;

public interface ICaseBuilder : IBaseBuilder<PcCase>
{
    public ICaseBuilder SetDimensions(Dimensions dimensions);
    public ICaseBuilder SetMaximumGpuDimensions(Dimensions dimensions);
    public ICaseBuilder SetMotherboardFormFactor(MotherBoardFormFactor formFactor);
    public ICaseBuilder SetName(string name);
}