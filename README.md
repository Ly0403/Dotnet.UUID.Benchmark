# Dotnet.UUID.Benchmark

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4 [AttachedDebugger]
  DefaultJob : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4


```
| Method              | Mean     | Error    | StdDev   | Median   | Gen0    | Gen1   | Allocated |
|-------------------- |---------:|---------:|---------:|---------:|--------:|-------:|----------:|
| SelectSimpleInteger | 215.2 μs |  9.42 μs | 27.47 μs | 209.9 μs | 17.5781 | 5.8594 |   72.4 KB |
| SelectGuidv4        | 188.5 μs |  7.32 μs | 21.59 μs | 181.4 μs | 17.5781 |      - |  72.25 KB |
| SelectGuidv7        | 203.4 μs | 10.02 μs | 28.74 μs | 194.3 μs | 17.5781 |      - |  72.25 KB |


```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 2.42GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4 [AttachedDebugger]
  DefaultJob : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v4


```
| Method              | Mean      | Error    | StdDev    | Median    | Gen0      | Gen1     | Allocated |
|-------------------- |----------:|---------:|----------:|----------:|----------:|---------:|----------:|
| InsertSimpleInteger |  22.62 ms | 0.819 ms |  2.375 ms |  22.79 ms | 1000.0000 | 750.0000 |   6.04 MB |
| InsertGuidv4        | 117.32 ms | 8.270 ms | 23.595 ms | 124.73 ms | 1000.0000 | 818.1818 |   5.89 MB |
| InsertGuidv7        |  16.79 ms | 0.397 ms |  1.147 ms |  16.89 ms | 1000.0000 | 906.2500 |   5.86 MB |
