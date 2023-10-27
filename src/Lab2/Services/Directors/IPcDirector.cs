using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public interface IPcDirector : IBaseDirector<PersonalComputerParts, IPcBuilder>
{
    public ComputerStatus AttemptBuild();
    public void WithValidator(IPartsCompatibilityValidator validator);
}