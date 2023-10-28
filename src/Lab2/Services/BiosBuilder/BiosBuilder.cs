using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

public class BiosBuilder : IBiosBuilder
{
    private string biosType = "none";
    private string biosVersion = "none";
    private IList<string> compatibleCpus = new List<string>();

    public Bios Build()
    {
         return new Bios(
            biosType,
            biosVersion,
            compatibleCpus);
    }

    public IBiosBuilder SetBiosType(string biosType)
    {
        BiosType = biosType;
        return this;
    }

    public IBiosBuilder SetBiosVersion(string biosVersion)
    {
        BiosVersion = biosVersion;
        return this;
    }

    public IBiosBuilder SetCompatibleCpus(IList<string> compatibleCpus)
    {
        CompatibleCpus = compatibleCpus;
        return this;
    }
}