using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Fuel;

public class JumpAndImpulseFuel : IFuelUsage
{
    public JumpAndImpulseFuel()
    {
        FuelUsed = new Dictionary<int, double>
        {
            { FuelId.ImpulseFuelId, 0 },
            { FuelId.JumpFuelId, 0 },
        };
    }

    private IDictionary<int, double> FuelUsed { get; set; }

    public double GetFuelCost(IFuelMarket market)
    {
        return market.GetTotalCost(FuelUsed);
    }

    public void AddFuelUsage(int id, double fuelUsed)
    {
        FuelUsed[id] += fuelUsed;
    }
}