using BenchmarkDotNet.Attributes;

namespace Dotnet.UUID.Benchmark;

[MemoryDiagnoser]
public class InsertBenchmark
{
    private const int _size = 1_000;

    [Benchmark]
    public async Task<bool> InsertSimpleInteger()
    {
        using var dbContext = new AppDbContext();

        dbContext.Database.EnsureCreated();

        for (int i = 0; i < _size; i++)
        {
            dbContext.Set<SimpleInt>().Add(new SimpleInt());
        }

        await dbContext.SaveChangesAsync();
        return true;
    }


    [Benchmark]
    public async Task<bool> InsertGuidv4()
    {
        using var dbContext = new AppDbContext();

        for (int i = 0; i < _size; i++)
        {
            dbContext.Set<Guidv4>().Add(new Guidv4() { Id = Guid.NewGuid() });
        }

        await dbContext.SaveChangesAsync();
        return true;
    }


    [Benchmark]
    public async Task<bool> InsertGuidv7()
    {
        using var dbContext = new AppDbContext();

        for (int i = 0; i < _size; i++)
        {
            dbContext.Set<Guidv7>().Add(new Guidv7() { Id = Guid.CreateVersion7() });
        }

        await dbContext.SaveChangesAsync();
        return true;
    }
}
