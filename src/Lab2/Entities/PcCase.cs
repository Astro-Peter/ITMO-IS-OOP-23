using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record PcCase(Dimensions Dimensions, MotherBoardFormFactor FormFactor, Dimensions GpuDimensions, string Name);