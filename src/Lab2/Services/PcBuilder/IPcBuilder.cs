using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.PcBuilder;

public interface IPcBuilder : IBaseBuilder<PersonalComputerParts>,
    ISetMotherboard<IPcBuilder>,
    ISetCpu<IPcBuilder>,
    ISetGpu<IPcBuilder>,
    ISetHdds<IPcBuilder>,
    ISetSsds<IPcBuilder>,
    ISetCoolingSystem<IPcBuilder>,
    ISetPcCase<IPcBuilder>,
    ISetRam<IPcBuilder>,
    ISetPowerSupply<IPcBuilder>,
    ISetWifiAdapter<IPcBuilder>,
    IAddHdd<IPcBuilder>,
    IAddSsd<IPcBuilder>,
    IAddRamStick<IPcBuilder>
{
}