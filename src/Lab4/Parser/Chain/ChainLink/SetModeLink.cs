using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class SetModeLink : BaseLink
{
    private readonly ICommandWithModeBuilder _builder;
    public SetModeLink(ICommandWithModeBuilder builder)
    {
        _builder = builder;
    }

    public override ParsingResult Handle(IRequestIterator request)
    {
        if (request.GetCurrentObject() == "-m")
        {
            request.Advance();
            _builder.SetMode(request.GetCurrentObject());
        }

        return NextLink?.Handle(request) ?? new ParsingResult.Success(_builder);
    }
}