using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public interface ICheckGuaranteeVoided
{
    public bool CheсkGuarantee(PersonalComputerParts parts);
}