using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PartsCompatabilityValidator;

public interface IComputerValidator
{
    public ComputerStatus Validate(PersonalComputerParts parts);
}