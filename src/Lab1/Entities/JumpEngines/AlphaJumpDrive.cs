using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class AlphaJumpDrive : IJumpDrive
{
    public JumpResult Traverse(double unitsOfSpace)
    {
        return unitsOfSpace > JumpDrivesLimits.AlphaLimit ? new JumpResult(RouteCompletionResult.CrewLost, 0) : new JumpResult(RouteCompletionResult.Success, unitsOfSpace);
    }
}