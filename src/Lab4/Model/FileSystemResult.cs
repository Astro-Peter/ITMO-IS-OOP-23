using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.Model;

public abstract record FileSystemResult
{
    public record Failure(string Issue) : FileSystemResult;

    public record Success() : FileSystemResult;

    public record FileReadResult(IList<byte> Result) : FileSystemResult;

    public record TreeResult(ITreeElement Result) : FileSystemResult;
}