using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.TripComparison;

public interface ITripCompare
{
    public bool Compare(ITripInfo first, ITripInfo second);
}