﻿using System.Diagnostics;

namespace CSharpFastPFOR.Benchmarks.Port
{
    public static class System
    {
        public static long nanoTime()
        {
            return (long)(Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 1000000000.0));
        }
    }
}