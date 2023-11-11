using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;

public class ConsoleLogger : ILogger
{
    private int Count { get; set; }
    public void LogMessage(string message)
    {
        Console.Out.WriteLine("Message #{0}", ++Count);
        Console.Out.WriteLine(message);
    }
}