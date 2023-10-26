using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetWifiAdapter<out T>
{
    public T SetWifiAdapter(WifiAdapter? wifiAdapter);
}