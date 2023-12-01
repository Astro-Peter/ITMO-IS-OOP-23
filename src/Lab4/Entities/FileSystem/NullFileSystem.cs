using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

public class NullFileSystem : IFileSystem
{
    public FileSystemResult SetPath(string path)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }

    public FileSystemResult GetTree(int depth)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }

    public FileSystemResult ReadFile(string path)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }

    public FileSystemResult DeleteFile(string path)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }

    public FileSystemResult CopyFile(string filePath, string newPath)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }

    public FileSystemResult MoveFile(string filePath, string newPath)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }

    public FileSystemResult RenameFile(string filePath, string newName)
    {
        return new FileSystemResult.Failure("No filesystem connected");
    }
}