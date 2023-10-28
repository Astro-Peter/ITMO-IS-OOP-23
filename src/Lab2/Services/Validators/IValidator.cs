using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public interface IValidator
{
    public ComputerStatus ValidateBuild(PersonalComputerParts parts);
}