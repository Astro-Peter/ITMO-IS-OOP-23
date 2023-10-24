using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetCompatibleCpus<out T>
{
    public T SetCompatibleCpus(IList<string> compatibleCpus);
}