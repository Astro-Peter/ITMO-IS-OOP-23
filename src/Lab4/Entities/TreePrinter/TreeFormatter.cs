using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;

public class TreeFormatter : ITreeFormatter
{
    private readonly IPrinter _printer;
    private int _depth;

    public TreeFormatter(IPrinter printer)
    {
        _printer = printer;
    }

    public string FileSymbol { get; set; } = "_f_/\\ ";
    public string TabSymbol { get; set; } = "\t";
    public string DirSymbol { get; set; } = "_d_/\\ ";

    public void VisitDirectory(DirectoryElement element)
    {
        string tabs = string.Concat(Enumerable.Repeat(TabSymbol, _depth)) + DirSymbol + element.Name;
        _printer.Print(tabs);

        _depth += 1;

        foreach (ITreeElement treeElement in element.Elements)
        {
            treeElement.Accept(this);
        }

        _depth -= 1;
    }

    public void VisitFile(FileElement element)
    {
        string tabs = string.Concat(Enumerable.Repeat(TabSymbol, _depth)) + FileSymbol + element.Name;
        _printer.Print(tabs);
    }
}