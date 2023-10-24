using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.WifiAdapterBuilder;

public class WifiAdapterBuilder : IWifiAdapterBuilder
{
    private bool? Bluetooth { get; set; }
    private string? PciEVersion { get; set; }
    private int? Power { get; set; }
    private string? Name { get; set; }
    private string? WifiStandard { get; set; }
    public WifiAdapter Build()
    {
        return new WifiAdapter(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            WifiStandard ?? throw new UndefinedParameterException(nameof(WifiStandard)),
            Bluetooth ?? throw new UndefinedParameterException(nameof(Bluetooth)),
            PciEVersion ?? throw new UndefinedParameterException(nameof(PciEVersion)),
            Power ?? throw new UndefinedParameterException(nameof(Power)));
    }

    public IWifiAdapterBuilder SetBluetooth(bool bluetooth)
    {
        Bluetooth = bluetooth;
        return this;
    }

    public IWifiAdapterBuilder SetPciEVersion(string pciEVersion)
    {
        PciEVersion = pciEVersion;
        return this;
    }

    public IWifiAdapterBuilder SetPower(int powerUsage)
    {
        Power = powerUsage;
        return this;
    }

    public IWifiAdapterBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public IWifiAdapterBuilder SetWifiStandard(string wifiStandard)
    {
        WifiStandard = wifiStandard;
        return this;
    }
}