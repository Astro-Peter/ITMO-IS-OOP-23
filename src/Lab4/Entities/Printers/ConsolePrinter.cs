using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Printers;

public class ConsolePrinter : IPrinter
{
    public void Print(string data)
    {
        Console.WriteLine(data);
    }
}