using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class GetPathLink : BaseLink
{
    private readonly ICommandWithPathBuilder _builder;

    public GetPathLink(ICommandWithPathBuilder builder)
    {
        _builder = builder;
    }

    public override ParsingResult Handle(IRequestIterator request)
    {
        _builder.SetPath(request.GetCurrentObject());
        request.Advance();
        return NextLink?.Handle(request) ?? new ParsingResult.Success(_builder);
    }
}