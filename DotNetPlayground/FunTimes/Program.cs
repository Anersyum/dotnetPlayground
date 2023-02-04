using BenchmarkDotNet.Running;
using FunTimes.Benchmarks;
using FunTimes.TaskVsValueTask;

//BenchmarkRunner.Run<TaskVsValueTaskBenchmark>();

TasksExample tasksExample = new();

await tasksExample.AwaitValueTaskMultipleTimes();
await tasksExample.AwaitTaskMultipleTimes();