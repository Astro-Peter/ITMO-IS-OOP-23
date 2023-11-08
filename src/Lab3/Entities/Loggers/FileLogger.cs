using System.IO;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;

public class FileLogger : ILogger
{
    private readonly StreamWriter _logFile;

    public FileLogger(string fileName)
    {
        _logFile = File.AppendText(fileName);
    }

    private int Cnt { get; set; }

    public void LogMessage(Message message)
    {
        _logFile.WriteLine("Message #{0}", ++Cnt);
        _logFile.WriteLine(message.Header);
        _logFile.WriteLine(message.PriorityLevel);
    }
}