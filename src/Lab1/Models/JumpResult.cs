namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class JumpResult
{
    public JumpResult(RouteCompletionResult completed, double fuelSpent)
    {
        Completed = completed;
        FuelSpent = fuelSpent;
    }

    public RouteCompletionResult Completed { get; }
    public double FuelSpent { get; }
}