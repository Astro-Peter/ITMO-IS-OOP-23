using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public interface IBaseDirector<T, TB>
    where TB
    : IBaseBuilder<T>
{
    public void BuildWith(TB baseBuilder);
    public void BuildFrom(T baseComponent);
    public T GetComponent();
}