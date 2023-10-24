using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CoolerBuilder;

public class CoolerBuilder : ICoolerBuilder
{
    private string? Name { get; set; }
    private Dimensions? Dimensions { get; set; }
    private IList<string>? Sockets { get; set; }
    private int? Tdp { get; set; }

    public CoolingSystem Build()
    {
        return new CoolingSystem(
            Name ?? throw new UndefinedParameterException(nameof(Name)),
            Dimensions ?? throw new UndefinedParameterException(nameof(Dimensions)),
            Sockets ?? throw new UndefinedParameterException(nameof(Sockets)),
            Tdp ?? throw new UndefinedParameterException(nameof(Tdp)));
    }

    public ICoolerBuilder SetName(string name)
    {
        Name = name;
        return this;
    }

    public ICoolerBuilder SetDimensions(Dimensions dimensions)
    {
        Dimensions = dimensions;
        return this;
    }

    public ICoolerBuilder SetCompatibleSockets(IList<string> sockets)
    {
        Sockets = sockets;
        return this;
    }

    public ICoolerBuilder SetTdp(int tdp)
    {
        Tdp = tdp;
        return this;
    }
}