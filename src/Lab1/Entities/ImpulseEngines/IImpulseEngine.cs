using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public interface IImpulseEngine
{
    public ITripInfo Travel(IAdjustSpeed speedAdjustment);
}