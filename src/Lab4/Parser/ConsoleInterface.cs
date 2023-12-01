using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Model;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Parser;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public static class ConsoleInterface
{
    public static void Start()
    {
        ILink start = RegularChainBuilder.Build();
        IParser parser = new Parser.Parser(start);
        IContext context = new Context();
        while (Console.ReadLine() is { } request && request != ":q")
        {
            ParsingResult builder = parser.Parse(request);
            if (builder is ParsingResult.Success successParsingResult)
            {
                BuildResult command = successParsingResult.Builder.Build();
                if (command is BuildResult.BuildSuccess s)
                {
                    CommandResult commandResult = s.Command.Execute(context);
                    if (commandResult is CommandResult.Failure failure)
                    {
                        Console.WriteLine(failure.Result);
                    }
                }
                else if (command is BuildResult.BuildFailure bf)
                {
                    Console.WriteLine(bf.Message);
                }
            }
            else if (builder is ParsingResult.Failure f)
            {
                Console.WriteLine(f.Issue);
            }
        }
    }
}