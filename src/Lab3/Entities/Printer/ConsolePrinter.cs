using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Printer;

public class ConsolePrinter : IPrinter
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}