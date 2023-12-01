using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Tree;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.FileSystem;

public class LocalFileSystem : IFileSystem
{
    private string _absolutePath = string.Empty;

    public FileSystemResult SetPath(string path)
    {
        if (!Path.IsPathRooted(path))
        {
            if (string.IsNullOrEmpty(_absolutePath))
            {
                return new FileSystemResult.Failure("Path is not rooted");
            }

            path = _absolutePath + '\\' + path;
        }

        if (!Path.Exists(path))
        {
            return new FileSystemResult.Failure("Path not found");
        }

        _absolutePath = path;
        return new FileSystemResult.Success();
    }

    public FileSystemResult GetTree(int depth)
    {
        if (!Directory.Exists(_absolutePath))
        {
            return new FileSystemResult.Failure("Given directory doesn't exist");
        }

        var elems = new List<ITreeElement>();
        foreach (string name in Directory.GetFiles(_absolutePath))
        {
            elems.Add(new FileElement(Path.GetFileName(name)));
        }

        foreach (string directory in Directory.GetDirectories(_absolutePath))
        {
            FileSystemResult dir = GetTree(directory, depth - 1);
            if (dir is FileSystemResult.TreeResult d)
            {
                elems.Add(d.Result);
            }
        }

        return new FileSystemResult.TreeResult(new DirectoryElement(elems, Path.GetFileName(_absolutePath)));
    }

    public FileSystemResult ReadFile(string path)
    {
        path = AdjustToAbsolute(path);

        if (!File.Exists(path))
        {
            return new FileSystemResult.Failure("File not found");
        }

        return new FileSystemResult.FileReadResult(File.ReadAllBytes(path));
    }

    public FileSystemResult DeleteFile(string path)
    {
        path = AdjustToAbsolute(path);

        if (!File.Exists(path))
        {
            return new FileSystemResult.Failure("File not found");
        }

        File.Delete(path);
        return new FileSystemResult.Success();
    }

    public FileSystemResult CopyFile(string filePath, string newPath)
    {
        filePath = AdjustToAbsolute(filePath);
        newPath = AdjustToAbsolute(newPath);

        if (!File.Exists(filePath))
        {
            return new FileSystemResult.Failure("File not found");
        }

        if (!Path.Exists(newPath))
        {
            return new FileSystemResult.Failure("Destination dir not found");
        }

        string destination = newPath + Path.GetFileName(filePath);
        string newFilePath = destination;
        int count = 1;
        while (File.Exists(newFilePath))
        {
            newFilePath = destination + count;
            count++;
        }

        File.Copy(filePath, newFilePath);
        return new FileSystemResult.Success();
    }

    public FileSystemResult MoveFile(string filePath, string newPath)
    {
        FileSystemResult copyResult = CopyFile(filePath, newPath);
        if (copyResult is FileSystemResult.Failure)
        {
            return copyResult;
        }

        FileSystemResult deletionResult = DeleteFile(filePath);
        if (deletionResult is FileSystemResult.Failure)
        {
            return deletionResult;
        }

        return new FileSystemResult.Success();
    }

    public FileSystemResult RenameFile(string filePath, string newName)
    {
        filePath = AdjustToAbsolute(filePath);

        if (!File.Exists(filePath))
        {
            return new FileSystemResult.Failure("File not found");
        }

        string? directoryPath = Path.GetDirectoryName(filePath);
        if (directoryPath is null)
        {
            return new FileSystemResult.Failure("This shouldn't even happen");
        }

        string newPath = directoryPath + newName;
        int count = 1;
        while (File.Exists(newPath))
        {
            newPath = directoryPath + newName + count;
            count++;
        }

        File.Move(filePath, newPath);
        return new FileSystemResult.Success();
    }

    private string AdjustToAbsolute(string path)
    {
        if (!Path.IsPathRooted(path))
        {
            path = _absolutePath + path;
        }

        return path;
    }

    private FileSystemResult GetTree(string path, int depth)
    {
        if (depth == 0)
        {
            return new FileSystemResult.TreeResult(new DirectoryElement(
                new List<ITreeElement>(),
                Path.GetFileName(path)));
        }

        var elems = new List<ITreeElement>();
        foreach (string name in Directory.GetFiles(path))
        {
            elems.Add(new FileElement(Path.GetFileName(name)));
        }

        foreach (string directory in Directory.GetDirectories(path))
        {
            FileSystemResult dir = GetTree(directory, depth - 1);
            if (dir is FileSystemResult.TreeResult d)
            {
                elems.Add(d.Result);
            }
        }

        return new FileSystemResult.TreeResult(new DirectoryElement(elems, Path.GetFileName(path)));
    }
}