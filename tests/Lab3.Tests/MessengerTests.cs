using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.User;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTests
{
    [Fact]
    public void SentMessageToUser_MessageUnread_DidntRead()
    {
        var user = new User();
        var userAddressee = new UserAddressee(user);
        userAddressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.False(user.Messages[0].Read);
    }

    [Fact]
    public void SetMessageRead_MessageWasRead_MessageReadFirstTime()
    {
        var user = new User();
        var userAddressee = new UserAddressee(user);
        userAddressee.ReceiveMessage(new Message("one", "two", 3));
        user.Messages[0].SetStatusRead();
        Assert.True(user.Messages[0].Read);
    }

    [Fact]
    public void SetMessageRead_ReceiveFailure_MessageReadSecondTime()
    {
        var user = new User();
        var userAddressee = new UserAddressee(user);
        userAddressee.ReceiveMessage(new Message("one", "two", 3));
        user.Messages[0].SetStatusRead();
        Assert.IsType<MessageStatusChange.Failure>(user.Messages[0].SetStatusRead());
    }

    [Fact]
    public void TestPriorityFilterWorks_NoMessageReceived_MessagePriorityLowerThanRequired()
    {
        var logger = new MockLogger();
        var addressee = new MessagePriorityFilter(new AddresseeWithLogger(new UserAddressee(new User()), logger), 4);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal(0, logger.Count);
    }

    [Fact]
    public void TestLoggerIsCalled_LoggerIsCalledOnce_OneMessageReceived()
    {
        var logger = new MockLogger();
        var addressee = new AddresseeWithLogger(new UserAddressee(new User()), logger);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal("one\ntwo", logger.LastMessage);
        Assert.Equal(1, logger.Count);
    }

    [Fact]
    public void TestMessenger_MessengerWritesMessage_MessageReceived()
    {
        var messenger = new MockMessenger();
        var addressee = new MessengerForward(messenger);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal("Messenger:\none\ntwo", messenger.Output);
    }

    private class MockMessenger : IMessenger
    {
        public string Output { get; private set; } = string.Empty;

        public void ShowMessage(string message)
        {
            Output += "Messenger:\n";
            Output += message;
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