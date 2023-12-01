using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class GetSecondPathLink : BaseLink
{
    private readonly ICommandWithTwoPathsBuilder _builder;

    public GetSecondPathLink(ICommandWithTwoPathsBuilder builder)
    {
        _builder = builder;
    }

    public override ParsingResult Handle(IRequestIterator request)
    {
        _builder.SetSecondPath(request.GetCurrentObject());
        request.Advance();
        return NextLink?.Handle(request) ?? new ParsingResult.Success(_builder);
    }
}