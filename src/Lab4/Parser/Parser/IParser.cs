using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Parser;

public interface IParser
{
    public ParsingResult Parse(string request);
}