using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tools;

public class ReadMessageException : Exception
{
    public ReadMessageException()
        : base("Message was already read")
    {
    }

    public ReadMessageException(string message)
        : base(message)
    {
    }

    public ReadMessageException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}