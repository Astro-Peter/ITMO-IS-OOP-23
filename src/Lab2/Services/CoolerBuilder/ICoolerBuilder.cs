using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CoolerBuilder;

public interface ICoolerBuilder : IBaseBuilder<CoolingSystem>
{
    public ICoolerBuilder SetName(string name);
    public ICoolerBuilder SetDimensions(Dimensions dimensions);
    public ICoolerBuilder SetCompatibleSockets(IList<string> sockets);
    public ICoolerBuilder SetTdp(int tdp);
}