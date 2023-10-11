using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class GammaJumpDrive : IJumpDrive
{
    public JumpResult Traverse(double unitsOfSpace)
    {
        return unitsOfSpace > JumpDrivesLimits.GammaLimit ? new JumpResult(false, 0) : new JumpResult(true, unitsOfSpace * unitsOfSpace);
    }
}