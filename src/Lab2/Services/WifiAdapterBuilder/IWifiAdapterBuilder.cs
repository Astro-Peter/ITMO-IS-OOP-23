using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.WifiAdapterBuilder;

public interface IWifiAdapterBuilder : IBaseBuilder<WifiAdapter>,
    ISetBluetooth<IWifiAdapterBuilder>,
    ISetPciEVersion<IWifiAdapterBuilder>,
    ISetPower<IWifiAdapterBuilder>,
    ISetName<IWifiAdapterBuilder>,
    ISetWifiStandard<IWifiAdapterBuilder>
{
}