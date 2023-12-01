using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.CommandBuilder;
using Itmo.ObjectOrientedProgramming.Lab4.Model;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class ParserTests
{
    [Fact]
    public void TestDisconnectCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        string command = new string("disconnect");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<DisconnectBuilder>(success.Builder);
        }
    }

    [Fact]
    public void TestConnectCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"connect C:\ -m local");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<ConnectBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);
            Assert.NotNull(builder.Mode);

            Assert.Equal(@"C:\", builder.Path1);
            Assert.Equal(@"local", builder.Mode);
        }
    }

    [Fact]
    public void TestTreeListCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"tree list -d 10");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<TreeDepthBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Depth);
            Assert.Equal(10, builder.Depth);
        }
    }

    [Fact]
    public void TestTreeGoToCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"tree goto folder");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<TreeGoToBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);

            Assert.Equal(@"folder", builder.Path1);
        }
    }

    [Fact]
    public void TestFileShowCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"file show test.txt -m console");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<FileShowBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);
            Assert.NotNull(builder.Mode);

            Assert.Equal(@"test.txt", builder.Path1);
            Assert.Equal(@"console", builder.Mode);
        }
    }

    [Fact]
    public void TestFileDeleteCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"file delete test.txt");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<DeleteFileBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);

            Assert.Equal(@"test.txt", builder.Path1);
        }
    }

    [Fact]
    public void TestFileCopyCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"file copy test.txt test2.txt");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<CopyFileBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);
            Assert.NotNull(builder.Path2);

            Assert.Equal(@"test.txt", builder.Path1);
            Assert.Equal(@"test2.txt", builder.Path2);
        }
    }

    [Fact]
    public void TestFileMoveCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"file move test.txt test2.txt");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<MoveFileBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);
            Assert.NotNull(builder.Path2);

            Assert.Equal(@"test.txt", builder.Path1);
            Assert.Equal(@"test2.txt", builder.Path2);
        }
    }

    [Fact]
    public void TestFileRenameCommand()
    {
        var parser = new Parser.Parser.Parser(RegularChainBuilder.Build());
        var mockParser = new Parser.Parser.Parser(MockChain());
        string command = new string(@"file rename test.txt test2.txt");
        ParsingResult result = parser.Parse(command);
        Assert.IsType<ParsingResult.Success>(result);
        if (result is ParsingResult.Success success)
        {
            Assert.IsType<RenameFileBuilder>(success.Builder);
        }

        ParsingResult mockResult = mockParser.Parse(command);
        Assert.IsType<ParsingResult.Success>(mockResult);
        if (mockResult is ParsingResult.Success { Builder: MockBuilder builder })
        {
            Assert.NotNull(builder.Path1);
            Assert.NotNull(builder.Path2);

            Assert.Equal(@"test.txt", builder.Path1);
            Assert.Equal(@"test2.txt", builder.Path2);
        }
    }

    private static ILink MockChain()
    {
        var builder = new MockBuilder();

        var connect = new CommandNameLink("connect", new List<ILink>());
        var connectPath = new GetPathLink(builder);
        var modeLink = new SetModeLink(builder);
        connectPath.AddLink(modeLink);
        connect.AddLink(connectPath);

        var fileLinks = new CommandNameLink("file", new List<ILink>());

        var copyFile = new CommandNameLink("copy", new List<ILink>());
        var firstPath = new GetPathLink(builder);
        var secondPath = new GetSecondPathLink(builder);
        firstPath.AddLink(secondPath);
        copyFile.AddLink(firstPath);
        fileLinks.AddLink(copyFile);

        var moveFile = new CommandNameLink("move", new List<ILink>());
        var firstPathMove = new GetPathLink(builder);
        var secondPathMove = new GetSecondPathLink(builder);
        firstPathMove.AddLink(secondPathMove);
        moveFile.AddLink(firstPathMove);
        fileLinks.AddLink(moveFile);

        var renameFile = new CommandNameLink("rename", new List<ILink>());
        var renameBuilder = new CopyFileBuilder();
        var firstPathRename = new GetPathLink(builder);
        var secondPathRename = new GetSecondPathLink(builder);
        firstPathRename.AddLink(secondPathRename);
        renameFile.AddLink(firstPathRename);
        fileLinks.AddLink(renameFile);

        var deleteFile = new CommandNameLink("delete", new List<ILink>());
        var pathDelete = new GetPathLink(builder);
        deleteFile.AddLink(pathDelete);
        fileLinks.AddLink(deleteFile);

        var showFile = new CommandNameLink("show", new List<ILink>());
        var pathShow = new GetPathLink(builder);
        var modeShow = new SetModeLink(builder);
        pathShow.AddLink(modeShow);
        showFile.AddLink(pathShow);
        fileLinks.AddLink(showFile);

        var treeLinks = new CommandNameLink("tree", new List<ILink>());

        var gotoLink = new CommandNameLink("goto", new List<ILink>());
        var gotoPath = new GetPathLink(builder);
        gotoLink.AddLink(gotoPath);
        treeLinks.AddLink(gotoLink);

        var listLink = new CommandNameLink("list", new List<ILink>());
        var listDepth = new GetDepthLink(builder);
        listLink.AddLink(listDepth);
        treeLinks.AddLink(listLink);

        var startLink = new StartLink(new List<ILink>()
        {
            treeLinks,
            fileLinks,
            connect,
        });
        return startLink;
    }

    private class MockBuilder : ICommandWithModeBuilder, ICommandWithTwoPathsBuilder, ICommandWithDepthBuilder
    {
        public string? Path1 { get; private set; }
        public string? Path2 { get; private set; }
        public int? Depth { get; private set; }
        public string? Mode { get; private set; }

        public BuildResult Build()
        {
            throw new System.NotImplementedException();
        }

        public void SetDepth(int depth)
        {
            Depth = depth;
        }

        public void SetPath(string path)
        {
            Path1 = path;
        }

        public void SetSecondPath(string path)
        {
            Path2 = path;
        }

        public void SetMode(string mode)
        {
            Mode = mode;
        }
    }
}