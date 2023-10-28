using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

public class BiosBuilder : IBiosBuilder
{
    private string _biosType = "none";
    private string _biosVersion = "none";
    private IList<string> _compatibleCpus = new List<string>();

    public Bios Build()
    {
        return new Bios(
            _biosType,
            _biosVersion,
            _compatibleCpus);
    }

    public IBiosBuilder SetBiosType(string biosType)
    {
        _biosType = biosType;
        return this;
    }

    public IBiosBuilder SetBiosVersion(string biosVersion)
    {
        _biosVersion = biosVersion;
        return this;
    }

    public IBiosBuilder SetCompatibleCpus(IList<string> compatibleCpus)
    {
        _compatibleCpus = compatibleCpus;
        return this;
    }
}