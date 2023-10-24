namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetWifiStandard<out T>
{
    public T SetWifiStandard(string wifiStandard);
}