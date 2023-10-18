using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;

public interface ISpaceSector
{
    public ITripInfo TraverseSector(ISpaceShip spaceShip);
}