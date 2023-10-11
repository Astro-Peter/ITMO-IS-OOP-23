using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;

public interface IJumpDrive
{
    public JumpResult Traverse(double unitsOfSpace);
}