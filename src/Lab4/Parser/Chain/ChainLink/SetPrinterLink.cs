using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

public class SetPrinterLink : BaseLink
{
    private readonly ICommandWithPrinterBuilder _builder;
    public SetPrinterLink(ICommandWithPrinterBuilder builder)
    {
        _builder = builder;
    }

    public override ParsingResult Handle(IRequestIterator request)
    {
        if (request.GetCurrentObject() == "-m")
        {
            request.Advance();
            if (request.GetCurrentObject() == "console")
            {
                _builder.SetPrinter(new ConsolePrinter());
            }
            else
            {
                return new ParsingResult.Failure("Unknown output mode");
            }
        }

        return NextLink?.Handle(request) ?? new ParsingResult.Success(_builder);
    }
}