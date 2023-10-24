using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

public class BiosBuilder : IBiosBuilder
{
    private string? BiosType { get; set; }
    private string? BiosVersion { get; set; }
    private IList<string>? CompatibleCpus { get; set; }

    public Bios Build()
    {
        return new Bios(
            BiosType ?? throw new UndefinedParameterException(nameof(BiosType)),
            BiosVersion ?? throw new UndefinedParameterException(nameof(BiosVersion)),
            CompatibleCpus ?? throw new UndefinedParameterException(nameof(CompatibleCpus)));
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