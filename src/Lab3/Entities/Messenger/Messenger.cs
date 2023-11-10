using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

public class Messenger : IMessenger
{
    public void ShowMessage(Message message)
    {
        Console.Out.WriteLine("Messenger:");
        Console.Out.WriteLine("{0}\n{1}", message.Header, message.Body);
    }
}