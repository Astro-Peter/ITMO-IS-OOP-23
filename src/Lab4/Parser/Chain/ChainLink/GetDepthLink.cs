using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class GetDepthLink : BaseLink
{
    private readonly ICommandWithDepthBuilder _builder;

    public GetDepthLink(ICommandWithDepthBuilder builder)
    {
        _builder = builder;
    }

    public override ParsingResult Handle(IRequestIterator request)
    {
        if (request.GetCurrentObject() == "-d")
        {
            if (!request.Advance())
            {
                return new ParsingResult.Failure("No depth value given");
            }

            if (!int.TryParse(request.GetCurrentObject(), out int val))
            {
                return new ParsingResult.Failure("Value of depth is not an integer");
            }

            if (val <= 0)
            {
                return new ParsingResult.Failure("Depth is not positive");
            }

            _builder.SetDepth(val);
        }

        return NextLink?.Handle(request) ?? new ParsingResult.Success(_builder);
    }
}