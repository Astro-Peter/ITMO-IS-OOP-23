using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

public interface IFileSystem
{
    public FileSystemResult SetPath(string path);
    public FileSystemResult GetTree(int depth);
    public FileSystemResult ReadFile(string path);
    public FileSystemResult DeleteFile(string path);
    public FileSystemResult CopyFile(string filePath, string newPath);
    public FileSystemResult MoveFile(string filePath, string newPath);
    public FileSystemResult RenameFile(string filePath, string newName);
}