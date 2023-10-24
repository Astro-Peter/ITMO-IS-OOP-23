namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetTdp<out T>
{
    public T SetTdp(int tdp);
}