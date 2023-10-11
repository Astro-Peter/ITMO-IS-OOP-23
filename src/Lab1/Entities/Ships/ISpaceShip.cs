using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public interface ISpaceShip
{
    public JourneyEngineInfo TraverseRegularEnvironment(double distance, bool hindered = false);
    public JumpResult UseJumpDrive(double distance);
    public bool DamageShip(int damage, int numberOfHits);
    public bool AntiMatterFlash(int power);
    public bool WhaleCollision(int numberOfHits);
    public ISpaceShip Copy();
}