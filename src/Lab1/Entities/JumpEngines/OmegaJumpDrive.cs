using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class OmegaJumpDrive : IJumpDrive
{
    public JumpResult Traverse(double unitsOfSpace)
    {
        return unitsOfSpace > JumpDrivesLimits.OmegaLimit ? new JumpResult(RouteCompletionResult.CrewLost, 0) : new JumpResult(RouteCompletionResult.Success, unitsOfSpace * Math.Log(unitsOfSpace));
    }
}