using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public class HighDensityNebula : ISpaceSector
{
    public HighDensityNebula(double distance, int antimatterFlashesNumber)
    {
        Distance = distance;
        AntimatterFlashesNumber = antimatterFlashesNumber;
    }

    private double Distance { get; }
    private int AntimatterFlashesNumber { get; }

    public SpaceShipTripSummary TraverseSector(ISpaceShip spaceShip)
    {
        bool crewAlive = spaceShip.AntiMatterFlash(AntimatterFlashesNumber);
        return !crewAlive ? new SpaceShipTripSummary(RouteCompletionResult.CrewLost) : spaceShip.UseJumpDrive(Distance);
    }
}