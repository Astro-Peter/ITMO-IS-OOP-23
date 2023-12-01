using Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;

public interface ITreeElement
{
    public void Accept(ITreeFormatter treeFormatter);
}