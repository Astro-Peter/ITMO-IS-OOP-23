using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class SetConnectionModeLink : BaseLink
{
    private readonly ICommandWithFileSystemBuilder _builder;
    public SetConnectionModeLink(ICommandWithFileSystemBuilder builder)
    {
        _builder = builder;
    }

    public override ParsingResult Handle(IRequestIterator request)
    {
        if (request.GetCurrentObject() == "-m")
        {
            request.Advance();
            if (request.GetCurrentObject() == "local")
            {
                _builder.SetFileSystem(new LocalFileSystem());
            }
            else
            {
                return new ParsingResult.Failure("Unknown connection mode");
            }
        }

        return NextLink?.Handle(request) ?? new ParsingResult.Success(_builder);
    }
}