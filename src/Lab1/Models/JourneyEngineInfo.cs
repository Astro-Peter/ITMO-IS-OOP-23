namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class JourneyInfo
{
    public JourneyInfo(double timeSpent, double fuelSpent)
    {
        TimeSpent = timeSpent;
        FuelSpent = fuelSpent;
    }

    public double TimeSpent { get; }
    public double FuelSpent { get; }
}