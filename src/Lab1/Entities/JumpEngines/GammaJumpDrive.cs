using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class GammaJumpDrive : IJumpDrive
{
    public SpaceShipTripSummary Traverse(double unitsOfSpace)
    {
        return unitsOfSpace > JumpDrivesConstants.GammaLimit ? new SpaceShipTripSummary(RouteCompletionResult.CrewLost) : new SpaceShipTripSummary(RouteCompletionResult.Success, 0, unitsOfSpace * unitsOfSpace, unitsOfSpace / JumpDrivesConstants.TimeAdjustment);
    }
}