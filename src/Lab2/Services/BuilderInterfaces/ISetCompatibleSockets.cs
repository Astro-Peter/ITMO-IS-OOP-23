using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetCompatibleSockets<out T>
{
    public T SetCompatibleSockets(IList<string> sockets);
}