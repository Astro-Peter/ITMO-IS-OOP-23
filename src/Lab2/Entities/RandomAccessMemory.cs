using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record RandomAccessMemory(
    string Name,
    int MemoryAmount,
    string Jedec,
    IList<XmpProfile> AvailableProfiles,
    string RamFormFactor,
    string DdrVersion,
    int PowerUsage);