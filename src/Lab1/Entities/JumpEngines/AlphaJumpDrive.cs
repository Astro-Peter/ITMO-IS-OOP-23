using Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public class AlphaJumpDrive : IJumpDrive
{
    private const double BaseFuelConsumptionRate = 1;
    private const int EngineLimit = 1000;
    private const int Speed = 20;

    public AlphaJumpDrive(double weight)
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

        return new SpaceShipTripSummary(
            RouteCompletionResult.Success,
            FuelId.JumpFuelId,
            speedAdjustment.Time * FuelConsumptionRate,
            speedAdjustment.Time);
    }
}