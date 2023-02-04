using BenchmarkDotNet.Attributes;
using FunTimes.TaskVsValueTask;

namespace FunTimes.Benchmarks;

[Config(typeof(FunTimes.Config))]
[MemoryDiagnoser]
public class TaskVsValueTaskBenchmark
{
    private readonly TasksExample _tasksExample = new();

    [Benchmark]
    public async Task TaskOperation() => await _tasksExample.TestTask();
    [Benchmark]
    public async Task TaskOperation2() => await _tasksExample.TestTask();
    [Benchmark]
    public async ValueTask ValueTaskOperation() => await _tasksExample.TestValueTask();

    [Benchmark]
    public async ValueTask ValueTaskOperation2() => await _tasksExample.TestValueTask();
}
