using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.WifiAdapterBuilder;

public interface IWifiAdapterBuilder : IBaseBuilder<WifiAdapter>
{
    public IWifiAdapterBuilder SetBluetooth(bool bluetooth);
    public IWifiAdapterBuilder SetPciEVersion(string pciEVersion);
    public IWifiAdapterBuilder SetPower(int powerUsage);
    public IWifiAdapterBuilder SetName(string name);
    public IWifiAdapterBuilder SetWifiStandard(string wifiStandard);
}