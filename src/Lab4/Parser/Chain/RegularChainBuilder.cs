using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Connect;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Copy;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Delete;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Move;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Rename;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands.Show;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands.List;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.TreeCommands.TreeGoTo;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain.ChainLink;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Chain;

public static class RegularChainBuilder
{
    public static StartLink Build()
    {
        var disconnect = new CommandNameLink("disconnect", new List<ILink> { new DisconnectLink() });

        var connect = new CommandNameLink("connect", new List<ILink>());
        var connectBuilder = new ConnectBuilder();
        var connectPath = new GetPathLink(connectBuilder);
        var modeLink = new SetConnectionModeLink(connectBuilder);
        connectPath.AddLink(modeLink);
        connect.AddLink(connectPath);

        var fileLinks = new CommandNameLink("file", new List<ILink>());

        var copyFile = new CommandNameLink("copy", new List<ILink>());
        var copyBuilder = new CopyFileBuilder();
        var firstPath = new GetPathLink(copyBuilder);
        var secondPath = new GetSecondPathLink(copyBuilder);
        firstPath.AddLink(secondPath);
        copyFile.AddLink(firstPath);
        fileLinks.AddLink(copyFile);

        var moveFile = new CommandNameLink("move", new List<ILink>());
        var moveBuilder = new MoveFileBuilder();
        var firstPathMove = new GetPathLink(moveBuilder);
        var secondPathMove = new GetSecondPathLink(moveBuilder);
        firstPathMove.AddLink(secondPathMove);
        moveFile.AddLink(firstPathMove);
        fileLinks.AddLink(moveFile);

        var renameFile = new CommandNameLink("rename", new List<ILink>());
        var renameBuilder = new RenameFileBuilder();
        var firstPathRename = new GetPathLink(renameBuilder);
        var secondPathRename = new GetSecondPathLink(renameBuilder);
        firstPathRename.AddLink(secondPathRename);
        renameFile.AddLink(firstPathRename);
        fileLinks.AddLink(renameFile);

        var deleteFile = new CommandNameLink("delete", new List<ILink>());
        var pathDelete = new GetPathLink(new DeleteFileBuilder());
        deleteFile.AddLink(pathDelete);
        fileLinks.AddLink(deleteFile);

        var showFile = new CommandNameLink("show", new List<ILink>());
        var showBuilder = new FileShowBuilder();
        var pathShow = new GetPathLink(showBuilder);
        var modeShow = new SetPrinterLink(showBuilder);
        pathShow.AddLink(modeShow);
        showFile.AddLink(pathShow);
        fileLinks.AddLink(showFile);

        var treeLinks = new CommandNameLink("tree", new List<ILink>());

        var gotoLink = new CommandNameLink("goto", new List<ILink>());
        var gotoPath = new GetPathLink(new TreeGoToBuilder());
        gotoLink.AddLink(gotoPath);
        treeLinks.AddLink(gotoLink);

        var listLink = new CommandNameLink("list", new List<ILink>());
        var listBuilder = new TreeDepthBuilder();
        var listDepth = new GetDepthLink(listBuilder);
        listLink.AddLink(listDepth);
        treeLinks.AddLink(listLink);

        var startLink = new StartLink(new List<ILink>()
        {
            treeLinks,
            fileLinks,
            connect,
            disconnect,
        });
        return startLink;
    }
}