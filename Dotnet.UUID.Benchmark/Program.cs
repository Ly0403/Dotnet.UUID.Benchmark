using BenchmarkDotNet.Running;
using Dotnet.UUID.Benchmark;



Console.WriteLine("Runnning Tests");
try
{
    BenchmarkRunner.Run<InsertBenchmark>();
    BenchmarkRunner.Run<SelectBenchmark>();
}
catch (Exception ex)
{
    Console.WriteLine($"Benchmark run failed: {ex}");
}

Console.WriteLine("Finished Tests");


