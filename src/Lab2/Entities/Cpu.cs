﻿namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public record Cpu(
    string Name,
    double Frequency,
    int CoreNumber,
    string Socket,
    Gpu? BuiltInGpu,
    double MaxRamFrequency,
    int Tdp,
    int PowerConsumption);