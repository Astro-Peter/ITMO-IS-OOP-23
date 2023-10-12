using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class AlphaJumpDrive : IJumpDrive
{
    public SpaceShipTripSummary Traverse(double unitsOfSpace)
    {
        return unitsOfSpace > JumpDrivesConstants.AlphaLimit ? new SpaceShipTripSummary(RouteCompletionResult.CrewLost) : new SpaceShipTripSummary(RouteCompletionResult.Success, 0, unitsOfSpace, unitsOfSpace / JumpDrivesConstants.TimeAdjustment);
    }
}