using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetSsds<out T>
{
    public T SetSsds(IList<Ssd>? ssds);
}