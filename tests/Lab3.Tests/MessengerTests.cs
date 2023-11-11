using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Printer;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.User;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTests
{
    [Fact]
    public void UserMessageReceive_MessageReadIsFalse_MessageWasntRead()
    {
        var user = new User();
        var userAddressee = new UserAddressee(user);
        userAddressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.False(user.Messages.First().Read);
    }

    [Fact]
    public void UserMessageReceive_MessageReadIsTrue_MessageWasRead()
    {
        var user = new User();
        var userAddressee = new UserAddressee(user);
        userAddressee.ReceiveMessage(new Message("one", "two", 3));
        user.Messages.First().SetStatusRead();
        Assert.True(user.Messages.First().Read);
    }

    [Fact]
    public void UserMessageReceive_GetError_MessageReadTwoTimes()
    {
        var user = new User();
        var userAddressee = new UserAddressee(user);
        userAddressee.ReceiveMessage(new Message("one", "two", 3));
        user.Messages.First().SetStatusRead();
        Assert.IsType<MessageStatusChange.Failure>(user.Messages.First().SetStatusRead());
    }

    [Fact]
    public void ReceiveMessage_NoMessageReceived_MessagePriorityLow()
    {
        var logger = new MockLogger();
        var addressee = new MessagePriorityFilter(new AddresseeWithLogger(new UserAddressee(new User()), logger), 4);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal(0, logger.Count);
    }

    [Fact]
    public void MessageReceive_LoggerIsCalledOnce_OneMessageReceived()
    {
        var logger = new MockLogger();
        var addressee = new AddresseeWithLogger(new UserAddressee(new User()), logger);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal("one\ntwo", logger.LastMessage);
        Assert.Equal(1, logger.Count);
    }

    [Fact]
    public void ShowMessage_MessengerWritesMessage_MessageReceived()
    {
        var printer = new MockPrinter();
        var addressee = new MessengerAddressee(new Messenger(printer));
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal("Messenger:\none\ntwo", printer.Output);
    }

    private class MockPrinter : IPrinter
    {
        public string Output { get; private set; } = string.Empty;

        public void ShowMessage(string message)
        {
            Output = message;
        }
    }

    private class MockLogger : ILogger
    {
        public int Count { get; private set; }
        public string LastMessage { get; private set; } = string.Empty;

        public void LogMessage(string message)
        {
            Count++;
            LastMessage = message;
        }
    }
}