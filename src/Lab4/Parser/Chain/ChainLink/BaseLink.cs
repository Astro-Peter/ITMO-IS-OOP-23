using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public abstract class BaseLink : ILink
{
    protected ILink? NextLink { get; private set; }

    public void AddLink(ILink nextLink)
    {
        if (NextLink is null)
        {
            NextLink = nextLink;
        }
        else
        {
            NextLink.AddLink(nextLink);
        }
    }

    public abstract ParsingResult Handle(IRequestIterator request);
}