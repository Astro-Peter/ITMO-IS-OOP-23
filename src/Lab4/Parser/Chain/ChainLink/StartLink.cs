using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class StartLink : ILink
{
    private IList<ILink> _links;

    public StartLink(IList<ILink> links)
    {
        _links = links;
    }

    public void AddLink(ILink nextLink)
    {
        _links.Add(nextLink);
    }

    public ParsingResult Handle(IRequestIterator request)
    {
        foreach (ILink link in _links)
        {
            ParsingResult result = link.Handle(request);
            if (result is ParsingResult.Success or ParsingResult.Failure)
            {
                return result;
            }
        }

        return new ParsingResult.Failure("Command does not exist");
    }
}