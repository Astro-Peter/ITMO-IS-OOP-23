using System.Collections;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record RandomAccessMemory(int MemoryAmount,
    string Jedec,
    IList<XmpProfile> AvailableProfiles,
    string RamFormFactor,
    string DdrVersion,
    int PowerUsage);