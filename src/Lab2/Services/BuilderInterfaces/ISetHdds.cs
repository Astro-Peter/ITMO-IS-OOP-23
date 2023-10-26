using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetHdds<out T>
{
    public T SetHdds(IList<Hdd>? hdds);
}