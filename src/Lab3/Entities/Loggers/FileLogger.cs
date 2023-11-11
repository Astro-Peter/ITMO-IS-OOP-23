using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;

public class FileLogger : ILogger
{
    private readonly StreamWriter _logFile;

    public FileLogger(string fileName)
    {
        _logFile = File.AppendText(fileName);
    }

    private int Count { get; set; }

    public void LogMessage(string message)
    {
        _logFile.WriteLine("Message #{0}", ++Count);
        _logFile.WriteLine(message);
    }
}