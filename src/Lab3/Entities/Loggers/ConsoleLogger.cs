using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;

public class ConsoleLogger : ILogger
{
    private int Cnt { get; set; }
    public void LogMessage(Message message)
    {
        Console.Out.WriteLine("Message #{0}", ++Cnt);
        Console.Out.WriteLine(message.Header);
        Console.Out.WriteLine(message.PriorityLevel);
    }
}