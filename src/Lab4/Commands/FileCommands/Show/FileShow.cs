using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Show;

public class FileShow : IFileSystemCommand
{
    private readonly string _fileName;
    private readonly IPrinter _printer;

    public FileShow(string fileName, IPrinter printer)
    {
        _fileName = fileName;
        _printer = printer;
    }

    public CommandResult Execute(IContext context)
    {
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