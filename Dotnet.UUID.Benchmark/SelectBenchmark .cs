using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.UUID.Benchmark;

[MemoryDiagnoser]
public class SelectBenchmark
{
    private const int _size = 1_00;

    [Benchmark]
    public async Task<bool> SelectSimpleInteger()
    {
        using var dbContext = new AppDbContext();

        var items = dbContext.Set<SimpleInt>().AsNoTracking()
            .OrderBy(x => x.Id)
            .Skip(_size)
            .Take(100)
            .ToListAsync();

        return true;
    }


    [Benchmark]
    public async Task<bool>SelectGuidv4()
    {
        using var dbContext = new AppDbContext();
        var items = dbContext.Set<SimpleInt>().AsNoTracking()
            .OrderBy(x => x.Id)
            .Skip(_size)
            .Take(100)
            .ToListAsync();
        return true;
    }


    [Benchmark]
    public async Task<bool> SelectGuidv7()
    {
        using var dbContext = new AppDbContext();

        var items = dbContext.Set<SimpleInt>().AsNoTracking()
        .OrderBy(x => x.Id)
        .Skip(_size)
        .Take(100)
        .ToListAsync();

        return true;
    }
}
