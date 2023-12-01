using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class DisconnectLink : BaseLink
{
    public override ParsingResult Handle(IRequestIterator request)
    {
        return new ParsingResult.Success(new DisconnectBuilder());
    }
}