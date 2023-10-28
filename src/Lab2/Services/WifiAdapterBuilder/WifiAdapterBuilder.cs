using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.WifiAdapterBuilder;

public class WifiAdapterBuilder : IWifiAdapterBuilder
{
    private bool _bluetooth;
    private string _pciEVersion = "none";
    private int _power;
    private string _name = "none";
    private string _wifiStandard = "none";
    public WifiAdapter Build()
    {
        return new WifiAdapter(
            _name,
            _wifiStandard,
            _bluetooth,
            _pciEVersion,
            _power);
    }

    public IWifiAdapterBuilder SetBluetooth(bool bluetooth)
    {
        _bluetooth = bluetooth;
        return this;
    }

    public IWifiAdapterBuilder SetPciEVersion(string pciEVersion)
    {
        _pciEVersion = pciEVersion;
        return this;
    }

    public IWifiAdapterBuilder SetPower(int powerUsage)
    {
        _power = powerUsage;
        return this;
    }

    public IWifiAdapterBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IWifiAdapterBuilder SetWifiStandard(string wifiStandard)
    {
        _wifiStandard = wifiStandard;
        return this;
    }
}