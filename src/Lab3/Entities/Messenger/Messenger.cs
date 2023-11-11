using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messenger;

public class Messenger : IMessenger
{
    public void ShowMessage(string message)
    {
        Console.Out.WriteLine("Messenger:");
        Console.Out.WriteLine(message);
    }
}