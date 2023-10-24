using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetXmpProfiles<out T>
{
    public T SetXmpProfiles(IList<XmpProfile> xmpProfiles);
}