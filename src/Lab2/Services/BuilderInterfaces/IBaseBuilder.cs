namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface IBaseBuilder<out T>
{
    public T Build();
}