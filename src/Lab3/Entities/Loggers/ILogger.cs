using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;

public interface ILogger
{
    void LogMessage(Message message);
}