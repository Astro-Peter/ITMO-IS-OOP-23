namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public record Message(string Header, string Body, int PriorityLevel)
{
    public override string ToString()
    {
        return Header + '\n' + Body;
    }
}