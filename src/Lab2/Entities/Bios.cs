using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record Bios(string Type, string Version, IList<string> CompatibleCpus);