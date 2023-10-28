using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.WifiAdapterBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class WifiAdapterDirector : IBaseDirector<IWifiAdapterBuilder>
{
    private readonly WifiAdapter _wifiAdapter;

    public WifiAdapterDirector(WifiAdapter wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
    }

    public IWifiAdapterBuilder Direct(IWifiAdapterBuilder baseBuilder)
    {
        baseBuilder.SetBluetooth(_wifiAdapter.Bluetooth)
            .SetName(_wifiAdapter.Name)
            .SetPower(_wifiAdapter.PowerUsage)
            .SetPciEVersion(_wifiAdapter.PciEVersion)
            .SetWifiStandard(_wifiAdapter.WifiStandard);
        return baseBuilder;
    }
}