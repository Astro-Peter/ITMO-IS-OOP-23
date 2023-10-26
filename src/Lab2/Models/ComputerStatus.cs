using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public record ComputerStatus(bool Guarantee, PowerConsumptionStatus Status, IList<string> Message);