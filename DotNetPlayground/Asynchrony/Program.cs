// await WhenAllDemo.Run(httpClient);
// await CancellationTokenDemo.Run();
// AggregateExceptionDemo.Run();
// await ContinueWithDemo.Run();

// Task task = ExceptionHandler(true);

// Console.WriteLine(task.IsCanceled);

// int numberResult = await AwaitablePatternDemo.Run();
//
// Console.WriteLine($"Gotovo sa rezultatom {numberResult}");

using System.Runtime.CompilerServices;

AsyncTaskMethodBuilder builder = AsyncTaskMethodBuilder.Create();

builder.AwaitUnsafeOnCompleted();