using BenchmarkDotNet.Attributes;
using FunTimes.TaskVsValueTask;

namespace FunTimes.Benchmarks
{
    [Config(typeof(Config))]
    [MemoryDiagnoser]
    public class TaskVsValueTaskBenchmark
    {
        private readonly TasksExample _tasksExample = new();

        public TaskVsValueTaskBenchmark()
        {
            _tasksExample.SaveResultToCache();
        }

        [Benchmark]
        public async Task TaskOperation() => await _tasksExample.TestTask();

        [Benchmark]
        public async ValueTask ValueTaskOperation() => await _tasksExample.TestValueTask();
    }
}