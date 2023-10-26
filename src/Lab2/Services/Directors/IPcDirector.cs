using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PartsCompatabilityValidator;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public interface IPcDirector : IBaseDirector<PersonalComputerParts, IPcBuilder>
{
    public ComputerStatus AttemptBuild();
    public void WithValidator(IComputerValidator validator);
}