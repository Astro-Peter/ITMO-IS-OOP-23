using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public interface IJumpEngine
{
    public JourneyEngineInfo Traverse(double unitsOfSpace);
}