using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Show;

public class FileShowBuilder : ICommandWithPathBuilder, ICommandWithPrinterBuilder
{
    private string? _name;
    private IPrinter? _printer;

    public void SetPath(string path)
    {
        _name = path;
    }

    public void SetPrinter(IPrinter printer)
    {
        _printer = printer;
    }

    public BuildResult Build()
    {
        if (_printer is null)
        {
            return new BuildResult.BuildFailure("Printer not defined");
        }

        if (_name is null)
        {
            return new BuildResult.BuildFailure("File name not defined");
        }

        return new BuildResult.BuildSuccess(new FileShow(_name, _printer));
    }
}