using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record Gpu(
    string Name,
    Dimensions Dimensions,
    int MemoryCapacity,
    string PciEVersion,
    double Frequency,
    int PowerUsage);