using Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;

public class AddresseeWithLogger : IAddressee
{
    private readonly IAddressee _addressee;

    private readonly ILogger _logger;

    public AddresseeWithLogger(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee;
        _logger = logger;
    }

    public void ReceiveMessage(Message message)
    {
        _logger.LogMessage(message);
        _addressee.ReceiveMessage(message);
    }
}