using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

public interface ITripInfo
{
    public double TimeSpent { get; }
    public RouteCompletionResult Result { get; }
    public ITripInfo Add(ITripInfo summary);
    public IDictionary<int, double> GetFuelSpent();
}