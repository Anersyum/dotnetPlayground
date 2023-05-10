using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Json;
using System.Text.Json;

namespace FunTimes.TaskVsValueTask;

public sealed class TasksExample
{
    private readonly IMemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());

    public async Task SaveResultToCache()
    {
        var result = await File.ReadAllTextAsync("ditto.json");

        _memoryCache.Set("ditto", result);
    }

    public async Task<string> TestTask()
    {
        var ditto = _memoryCache.Get<string>("ditto");

        if (ditto is null)
        {
            var result = await File.ReadAllTextAsync("ditto.json");

            _memoryCache.Set("ditto", result);

            ditto = result;
        }

        return ditto;
    }

    public async ValueTask<string> TestValueTask()
    {
        var ditto = _memoryCache.Get<string>("ditto");

        if (ditto is null)
        {
            var result = await File.ReadAllTextAsync("ditto.json");

            _memoryCache.Set("ditto", result);

            ditto = result;
        }

        return ditto;
    }

    public async ValueTask AwaitValueTaskMultipleTimes()
    {
        ValueTask<string> valueTask = TestValueTask();

        string a = await valueTask;
        string b = await valueTask;
        string c = await valueTask;
        string d = await valueTask;
        string e = await valueTask;

        Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, e: {e}");
    }

    public async Task AwaitTaskMultipleTimes()
    {
        Task<string> task = TestTask();
        
        string a = await task;
        string b = await task;
        string c = await task;
        string d = await task;
        string e = await task;

        Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, e: {e}");
    }
}
