using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class CommandNameLink : ILink
{
    private readonly string _name;
    private IList<ILink> _links;

    public CommandNameLink(string name, IList<ILink> links)
    {
        _name = name;
        _links = links;
    }

    public void AddLink(ILink nextLink)
    {
        _links.Add(nextLink);
    }

    public ParsingResult Handle(IRequestIterator request)
    {
        if (request.GetCurrentObject() == _name)
        {
            request.Advance();
            foreach (ILink link in _links)
            {
                ParsingResult result = link.Handle(request);
                if (result is ParsingResult.Success or ParsingResult.Failure)
                {
                    return result;
                }
            }

            return new ParsingResult.Failure("Command not found");
        }

        return new ParsingResult.IncorrectLink();
    }
}