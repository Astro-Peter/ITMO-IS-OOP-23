using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tools;

public class UndefinedParameterException : Exception
{
    public UndefinedParameterException(string errorMessage)
        : base(errorMessage)
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