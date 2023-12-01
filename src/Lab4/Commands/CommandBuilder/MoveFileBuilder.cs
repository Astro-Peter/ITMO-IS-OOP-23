﻿using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;

public class MoveFileBuilder : ICommandWithTwoPathsBuilder
{
    private string? _filePath;
    private string? _destinationPath;

    public BuildResult Build()
    {
        if (_filePath is null)
        {
            return new BuildResult.BuildFailure("File path is undefined");
        }

        if (_destinationPath is null)
        {
            return new BuildResult.BuildFailure("Destination is undefined");
        }

        return new BuildResult.BuildSuccess(new MoveFile(_filePath, _destinationPath));
    }

    public void SetPath(string path)
    {
        _filePath = path;
    }

    public void SetSecondPath(string path)
    {
        _destinationPath = path;
    }
}