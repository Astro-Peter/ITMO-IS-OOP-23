using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class OmegaJumpDrive : IJumpDrive
{
    public SpaceShipTripSummary Traverse(double unitsOfSpace)
    {
        return unitsOfSpace > JumpDrivesConstants.OmegaLimit ? new SpaceShipTripSummary(RouteCompletionResult.CrewLost) : new SpaceShipTripSummary(RouteCompletionResult.Success, 0, unitsOfSpace * Math.Log(unitsOfSpace), unitsOfSpace / JumpDrivesConstants.TimeAdjustment);
    }
}