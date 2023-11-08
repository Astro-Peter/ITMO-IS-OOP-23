using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Tools;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTests
{
    [Fact]
    public void TestMessageSentToUserSavedUnread()
    {
        var user = new UserAddressee();
        user.ReceiveMessage(new Message("one", "two", 3));
        Assert.False(user.Messages[0].GetIsRead());
    }

    [Fact]
    public void TestMessageStatusChangedWhenRequested()
    {
        var user = new UserAddressee();
        user.ReceiveMessage(new Message("one", "two", 3));
        user.Messages[0].SetStatusRead();
        Assert.True(user.Messages[0].GetIsRead());
    }

    [Fact]
    public void TestExceptionThrownWhenChangeStatusFromReadToRead()
    {
        var user = new UserAddressee();
        user.ReceiveMessage(new Message("one", "two", 3));
        user.Messages[0].SetStatusRead();
        Assert.Throws<ReadMessageException>(() => user.Messages[0].SetStatusRead());
    }

    [Fact]
    public void TestMockProxyWorks()
    {
        var logger = new MockLogger();
        var addressee = new AddresseeProxy(new AddresseeWithLogger(new UserAddressee(), logger), 4);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal(0, logger.Cnt);
    }

    [Fact]
    public void TestMockLogWorks()
    {
        var logger = new MockLogger();
        var addressee = new AddresseeWithLogger(new UserAddressee(), logger);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal(1, logger.Cnt);
    }

    [Fact]
    public void TestMockMessengerWorks()
    {
        var addressee = new MockMessenger();
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal("Messenger:\none\ntwo", addressee.Output);
    }

    private class MockMessenger : IAddressee
    {
        public string Output { get; set; } = string.Empty;

        public void ReceiveMessage(Message message)
        {
            Output += "Messenger:\n";
            Output += message.Header + '\n' + message.Body;
        }
    }

    private class MockLogger : ILogger
    {
        public int Cnt { get; set; }

        public void LogMessage(Message message)
        {
            Cnt++;
        }
    }
}