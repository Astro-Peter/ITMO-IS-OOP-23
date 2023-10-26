using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.WifiAdapterBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class WifiAdapterDirector : IBaseDirector<WifiAdapter, IWifiAdapterBuilder>
{
    public WifiAdapterDirector(IWifiAdapterBuilder builder)
    {
        Builder = builder;
    }

    public IWifiAdapterBuilder Builder { get; private set; }

    public void BuildWith(IWifiAdapterBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(WifiAdapter baseComponent)
    {
        Builder.SetBluetooth(baseComponent.Bluetooth)
            .SetName(baseComponent.Name)
            .SetPower(baseComponent.PowerUsage)
            .SetPciEVersion(baseComponent.PciEVersion)
            .SetWifiStandard(baseComponent.WifiStandard);
    }

    public WifiAdapter GetComponent()
    {
        return Builder.Build();
    }
}