using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tools;

public class UndefinedParameterException : Exception
{
    public UndefinedParameterException(string parameterName)
        : base(parameterName)
    {
    }

    public UndefinedParameterException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public UndefinedParameterException()
    {
    }
}