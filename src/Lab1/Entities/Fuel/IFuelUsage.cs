using Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Fuel;

public interface IFuelUsage
{
    public double GetFuelCost(IFuelMarket market);
    public void AddFuelUsage(int id, double fuelUsed);
}