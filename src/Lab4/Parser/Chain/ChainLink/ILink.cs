using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public interface ILink
{
    public void AddLink(ILink nextLink);
    public ParsingResult Handle(IRequestIterator request);
}