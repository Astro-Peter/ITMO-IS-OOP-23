namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.EnvironmentAdjustmentFormulas;

public interface IAdjustSpeed
{
    public double Time { get; }
    public double Distance { get; }
    public void GetSpeed(double speed);
}