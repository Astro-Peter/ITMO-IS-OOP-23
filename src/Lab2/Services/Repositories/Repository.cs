using System.Collections;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Repositories;

public class Repository<T> : IRepository<T>
{
    public Repository(IList<T> components)
    {
        Components = components;
    }

    public Repository()
    {
        Components = new List<T>();
    }

    public IEnumerable<T> Values => Components;

    private IList<T> Components { get; }

    public void Add(T component)
    {
        Components.Add(component);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}