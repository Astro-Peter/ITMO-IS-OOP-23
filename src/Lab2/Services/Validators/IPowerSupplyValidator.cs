using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public interface IPowerSupplyValidator
{
    public PowerConsumptionStatus CheckEnoughPower(PersonalComputerParts parts);
}