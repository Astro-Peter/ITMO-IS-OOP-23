using Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;

public class FileElement : ITreeElement
{
    public FileElement(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Accept(ITreeFormatter treeFormatter)
    {
        treeFormatter.VisitFile(this);
    }
}