using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public interface ISpaceShip
{
    public ITripInfo TraverseRegularEnvironment(IAdjustSpeed speedAdjustment);
    public ITripInfo UseJumpDrive(IAdjustSpeed speedAdjustment);
    public void DamageShip(ISpaceObject spaceObject);
    public ISpaceShip Copy();
}