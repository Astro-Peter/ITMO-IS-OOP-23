using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class TestShipOnEnvironment
{
    public TestShipOnEnvironment(ISpaceSector[] spaceSectors, ISpaceShip[] spaceShips)
    {
        SpaceShips = spaceShips;
        SpaceSectors = spaceSectors;
    }
    private ISpaceSector[]? SpaceSectors { get; set; }
    private ISpaceShip[]? SpaceShips { get; set; }

    public ISpaceShip? SelectOptimalShip()
    {
        if (SpaceShips == null)
        {
            throw new ArgumentNullException(nameof(SpaceShips));
        }

        if (SpaceSectors == null)
        {
            throw new ArgumentNullException(nameof(SpaceSectors));
        }
        int bestPossibleShip = -1;
        foreach (ISpaceShip spaceShip in SpaceShips)
        {
            ISpaceShip copySpaceShip = spaceShip.Copy();
            var spaceShipTripSummary = new SpaceShipTripSummary();
            foreach (ISpaceSector spaceSector in SpaceSectors)
            {
                SectorTripResult tripResult = spaceSector.TraverseSector(copySpaceShip);
                if (!tripResult.TripSuccessful)
                {
                    break;
                }

                if (spaceSector is HighDensityNebula)
                {
                    spaceShipTripSummary.AddJumpFuelSpent(tripResult);
                }
                else
                {
                    spaceShipTripSummary.AddRegularFuelSpent(tripResult);
                }
            }
        }
    }
}