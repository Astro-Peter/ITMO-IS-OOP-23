using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;

public class DirectoryElement : ITreeElement
{
    public DirectoryElement(IEnumerable<ITreeElement> elements, string name)
    {
        Elements = elements;
        Name = name;
    }

    public IEnumerable<ITreeElement> Elements { get; }

    public string Name { get; }

    public void Accept(ITreeFormatter treeFormatter)
    {
        treeFormatter.VisitDirectory(this);
    }
}