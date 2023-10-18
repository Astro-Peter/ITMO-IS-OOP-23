using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public interface IJumpDrive
{
    public ITripInfo Travel(IAdjustSpeed speedAdjustment);
}