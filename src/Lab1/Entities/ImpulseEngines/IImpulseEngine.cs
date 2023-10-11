using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;

public interface IImpulseEngine
{
    public JourneyEngineInfo TraverseChannel(double distance, int weight, bool hindered = false);
}