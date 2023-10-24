using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record Chipset(string Name, IList<double> AvailableMemoryFrequencies, bool XmpSupport);