using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

public interface IBiosBuilder : IBaseBuilder<Bios>
{
    public IBiosBuilder SetBiosType(string biosType);
    public IBiosBuilder SetBiosVersion(string biosVersion);
    public IBiosBuilder SetCompatibleCpus(IList<string> compatibleCpus);
}