using System.Runtime.InteropServices.ComTypes;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Comparators;

public static class CompareDimensions
{
    public static bool Compare(Dimensions lesser, Dimensions greater)
    {
        return lesser.Height < greater.Height && lesser.Width < greater.Width && lesser.Length < greater.Length;
    }
}