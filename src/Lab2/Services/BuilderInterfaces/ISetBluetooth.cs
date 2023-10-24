namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetBluetooth<out T>
{
    public T SetBluetooth(bool bluetooth);
}