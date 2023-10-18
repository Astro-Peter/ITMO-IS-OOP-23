using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;

public class HighDensitySpaceAdjustment : IAdjustSpeed
{
    public HighDensitySpaceAdjustment(double distance)
    {
        Time = 0;
        Distance = distance;
    }

    public double Time { get; private set; }
    public double Distance { get; private set; }

    public void GetSpeed(double speed)
    {
        Distance -= speed * EngineSharedConstants.EngineDeltaTime;
        Time += EngineSharedConstants.EngineDeltaTime;
    }
}