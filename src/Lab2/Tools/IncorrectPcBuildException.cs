using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tools;

public class IncorrectPcBuildException : Exception
{
    public IncorrectPcBuildException(string message)
        : base(message)
    {
    }

    public IncorrectPcBuildException()
    {
    }

    public IncorrectPcBuildException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}