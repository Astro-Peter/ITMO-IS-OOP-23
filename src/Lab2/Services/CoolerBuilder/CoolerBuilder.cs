using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.CoolerBuilder;

public class CoolerBuilder : ICoolerBuilder
{
    private Dimensions _dimensions = new(0, 0, 0);
    private string _name = "empty";
    private IList<string> _sockets = new List<string>();
    private int _tdp;

    public CoolingSystem Build()
    {
        return new CoolingSystem(
            _name,
            _dimensions,
            _sockets,
            _tdp);
    }

    public ICoolerBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public ICoolerBuilder SetDimensions(Dimensions dimensions)
    {
        _dimensions = dimensions;
        return this;
    }

    public ICoolerBuilder SetCompatibleSockets(IList<string> sockets)
    {
        _sockets = sockets;
        return this;
    }

    public ICoolerBuilder SetTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }
}