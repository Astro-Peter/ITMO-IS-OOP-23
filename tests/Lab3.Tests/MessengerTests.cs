using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Loggers;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTests
{
    [Fact]
    public void SentMessageToUser_MessageUnread_DidntRead()
    {
        var user = new UserAddressee();
        user.ReceiveMessage(new Message("one", "two", 3));
        Assert.False(user.Messages[0].GetIsRead());
    }

    [Fact]
    public void SetMessageRead_MessageWasRead_MessageReadFirstTime()
    {
        var user = new UserAddressee();
        user.ReceiveMessage(new Message("one", "two", 3));
        user.Messages[0].SetStatusRead();
        Assert.True(user.Messages[0].GetIsRead());
    }

    [Fact]
    public void SetMessageRead_ReceiveError_MessageReadSecondTime()
    {
        var user = new UserAddressee();
        user.ReceiveMessage(new Message("one", "two", 3));
        user.Messages[0].SetStatusRead();
        Assert.False(user.Messages[0].SetStatusRead().Ok);
    }

    [Fact]
    public void TestPriorityFilterWorks_NoMessageReceived_MessagePriorityLowerThanRequired()
    {
        var logger = new MockLogger();
        var addressee = new MessagePriorityFilter(new AddresseeWithLogger(new UserAddressee(), logger), 4);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal(0, logger.Cnt);
    }

    [Fact]
    public void TestLoggerIsCalled_LoggerIsCalledOnce_OneMessageReceived()
    {
        var logger = new MockLogger();
        var addressee = new AddresseeWithLogger(new UserAddressee(), logger);
        addressee.ReceiveMessage(new Message("one", "two", 3));
        Assert.Equal(1, logger.Cnt);
    }

    [Fact]
    public void TestMessenger_MessengerWritesMessage_MessageReceived()
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