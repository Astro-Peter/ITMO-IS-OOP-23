using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.TripInfo;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public interface ISpaceShip
{
    public IImpulseEngine TraverseRegularEnvironment(double distance);
    public IJumpDrive? UseJumpDrive(double distance);
    public void DamageShip(ISpaceObject spaceObject);
    public ISpaceShip Copy();
}