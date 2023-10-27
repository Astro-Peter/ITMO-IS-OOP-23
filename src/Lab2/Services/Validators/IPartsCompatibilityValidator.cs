using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public interface IPartsCompatibilityValidator
{
    public IList<string> Validate(PersonalComputerParts parts);
}