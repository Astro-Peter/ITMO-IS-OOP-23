namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class JumpResult
{
    public JumpResult(bool completed, double fuelSpent)
    {
        Completed = completed;
        FuelSpent = fuelSpent;
    }

    public bool Completed { get; }
    public double FuelSpent { get; }
}