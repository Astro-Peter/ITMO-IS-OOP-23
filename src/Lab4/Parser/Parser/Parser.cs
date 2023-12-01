using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Parser;

public class Parser : IParser
{
    private readonly ILink _linkStart;

    public Parser(ILink linkStart)
    {
        _linkStart = linkStart;
    }

    public ParsingResult Parse(string request)
    {
        var splitRequest = new RequestIterator(request);
        return _linkStart.Handle(splitRequest);
    }
}