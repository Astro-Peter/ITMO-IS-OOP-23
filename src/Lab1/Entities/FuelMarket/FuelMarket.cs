using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;

public class FuelMarket : IFuelMarket
{
    private static int ImpulseFuelCost => 10;
    private static int JumpFuelCost => 40;

    public double GetTotalCost(IDictionary<int, double> fuelConsumption)
    {
        double totalCost = 0;
        if (fuelConsumption.TryGetValue(FuelId.ImpulseFuelId, out double value))
        {
            totalCost += value * ImpulseFuelCost;
        }

        if (fuelConsumption.TryGetValue(FuelId.JumpFuelId, out value))
        {
            totalCost += value * JumpFuelCost;
        }

        return totalCost;
    }
}