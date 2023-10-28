using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class Validator : IValidator
{
    private readonly CheckGuaranteeVoided _guaranteeVoided = new();
    private readonly PartsCompatibilityValidator _partsCompatibilityValidator = new();
    private readonly PowerSupplyValidator _powerSupplyValidator = new();

    public ComputerStatus ValidateBuild(PersonalComputerParts parts)
    {
        return new ComputerStatus(
            _guaranteeVoided.ValidateBuild(parts).Guarantee,
            _powerSupplyValidator.ValidateBuild(parts).Status,
            _partsCompatibilityValidator.ValidateBuild(parts).Message);
    }
}