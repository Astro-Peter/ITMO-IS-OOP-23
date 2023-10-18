using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;

public interface IFuelMarket
{
    public double GetTotalCost(IDictionary<int, double> fuelConsumption);
}