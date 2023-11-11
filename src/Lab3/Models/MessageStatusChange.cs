namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public abstract record MessageStatusChange
{
    private MessageStatusChange() { }

    public record Success : MessageStatusChange;

    public record Failure(string Message) : MessageStatusChange;
}