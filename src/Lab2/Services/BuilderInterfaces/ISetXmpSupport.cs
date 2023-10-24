namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetXmpSupport<out T>
{
    public T SetXmpSupport(bool support);
}