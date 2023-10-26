using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Repositories;

public interface IRepository<T> : IEnumerable<T>
{
    public IEnumerable<T> Values { get; }
    public void Add(T component);
}