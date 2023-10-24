using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record CoolingSystem(string Name, Dimensions Dimensions, IList<string> CompatibleSockets, int Tdp);