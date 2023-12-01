using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Show;

public class FileShow : IFileSystemCommand
{
    private string _fileName;
    private string _mode;
    private IPrinter? _printer;

    public FileShow(string fileName, string mode)
    {
        _fileName = fileName;
        _mode = mode;
    }

    public CommandResult Execute(IContext context)
    {
        switch (_mode)
        {
            case "console":
                _printer = new ConsolePrinter();
                break;
            default:
                return new CommandResult.Failure("unknown mode");
        }

        FileSystemResult result = context.FileSystem.ReadFile(_fileName);

        if (result is FileSystemResult.Failure failure)
        {
            return new CommandResult.Failure(failure.Issue);
        }

        if (result is FileSystemResult.FileReadResult read)
        {
            _printer.Print(string.Join(' ', read.Result));
            return new CommandResult.Success();
        }

        return new CommandResult.Failure("Unknown issue occured");
    }
}