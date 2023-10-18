using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public class ImpulseEngineC : IImpulseEngine
{
    private const double BaseFuelConsumptionRate = 1;

    public ImpulseEngineC(double weight)
    {
        FuelConsumptionRate = BaseFuelConsumptionRate * weight;
    }

    private static double FlightSpeed => 1;
    private double FuelConsumptionRate { get; }

    public ITripInfo Travel(IAdjustSpeed speedAdjustment)
    {
        for (int i = 0; i < EngineSharedConstants.NumberOfUpdates && speedAdjustment.Distance > 0; i++)
        {
            speedAdjustment.GetSpeed(FlightSpeed);
        }

        if (speedAdjustment.Distance > 0)
            return new SpaceShipTripSummary(RouteCompletionResult.ShipLost);

        return new SpaceShipTripSummary(
            RouteCompletionResult.Success,
            FuelId.ImpulseFuelId,
            speedAdjustment.Time * FuelConsumptionRate,
            speedAdjustment.Time);
    }
}