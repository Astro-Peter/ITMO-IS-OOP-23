using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public interface ICommandWithPrinterBuilder : ICommandBuilder
{
    public void SetPrinter(IPrinter printer);
}