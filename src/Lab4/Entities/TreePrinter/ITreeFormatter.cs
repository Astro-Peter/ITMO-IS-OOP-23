using Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.TreePrinter;

public interface ITreeFormatter
{
    public void VisitDirectory(DirectoryElement element);
    public void VisitFile(FileElement element);
}