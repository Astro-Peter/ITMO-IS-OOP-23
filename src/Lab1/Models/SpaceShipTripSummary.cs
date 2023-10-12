using System.Net.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class SpaceShipTripSummary
{
    public SpaceShipTripSummary(
        RouteCompletionResult result,
        double regularFuelSpent = 0,
        double jumpFuelSpent = 0,
        double timeSpent = 0)
    {
        Result = result;
        RegularFuelSpent = regularFuelSpent;
        JumpFuelSpent = jumpFuelSpent;
        TimeSpent = timeSpent;
    }

    public RouteCompletionResult Result { get; private set; }
    public double RegularFuelSpent { get; private set; }
    public double JumpFuelSpent { get; private set; }
    public double TimeSpent { get; private set; }

    public void Add(SpaceShipTripSummary summary)
    {
        RegularFuelSpent += summary.RegularFuelSpent;
        JumpFuelSpent += summary.JumpFuelSpent;
        TimeSpent += summary.TimeSpent;
    }
}