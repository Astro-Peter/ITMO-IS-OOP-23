using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public record ComputerStatus(
    bool Guarantee,
    PowerConsumptionStatus Status,
    IList<string> Message);