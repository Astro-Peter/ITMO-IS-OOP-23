using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;

public class NeutrinoParticlesAdjustment : IAdjustSpeed
{
    public NeutrinoParticlesAdjustment(double distance)
    {
        Distance = distance;
        Time = 0;
    }

    public double Time { get; private set; }
    public double Distance { get; private set; }

    public void GetSpeed(double speed)
    {
        Distance -= double.Pow(2,  (0.01 * speed) - 2) * EngineSharedConstants.EngineDeltaTime;
        Time += EngineSharedConstants.EngineDeltaTime;
    }
}