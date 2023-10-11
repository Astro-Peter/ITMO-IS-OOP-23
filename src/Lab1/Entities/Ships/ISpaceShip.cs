using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public interface ISpaceShip
{
    public JourneyEngineInfo TraverseRegularEnvironment(double distance);
    public JumpResult UseJumpDrive(double distance);
    public DamageEventResult DamageShip(int damage);
}