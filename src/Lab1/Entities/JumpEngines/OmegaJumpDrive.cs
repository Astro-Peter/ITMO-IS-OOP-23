using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class OmegaJumpDrive : IJumpDrive
{
    private const double BaseFuelConsumptionRate = 1;
    private const int EngineLimit = 2000;
    private const int Speed = 20;

    public OmegaJumpDrive(double weight)
    {
        FuelConsumptionRate = BaseFuelConsumptionRate * weight;
    }

    private double FuelConsumptionRate { get; }

    public ITripInfo Travel(IAdjustSpeed speedAdjustment)
    {
        if (speedAdjustment.Distance > EngineLimit)
            return new SpaceShipTripSummary(RouteCompletionResult.ShipLost);

        for (int i = 0; i < EngineSharedConstants.NumberOfUpdates && speedAdjustment.Distance > 0; i++)
        {
            speedAdjustment.GetSpeed(Speed);
        }

        if (speedAdjustment.Distance > 0)
            return new SpaceShipTripSummary(RouteCompletionResult.ShipLost);

        double fuelConsumed = speedAdjustment.Time * FuelConsumptionRate;
        return new SpaceShipTripSummary(
            RouteCompletionResult.Success,
            FuelId.JumpFuelId,
            fuelConsumed * fuelConsumed,
            speedAdjustment.Time);
    }
}