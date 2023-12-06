using Asynchrony;
using Asynchrony.Demos;
// using AwaitablePattern;

// TasksExamplesDemo examplesDemo = new();
// await examplesDemo.RunTask();
await ContinueWithDemo.Run();
// await CancellationTokenDemo.Run();

// exception without awaiting
// try
// {
//     Task task = Task.Run(() => throw new Exception("Can you catch me?"));
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }
//
// await Task.Delay(TimeSpan.FromSeconds(3));
//
// Console.WriteLine("We're done.");

// await AggregateExceptionDemo.Run();

// DFiniteStateMachine stateMachine = new();
//
// stateMachine.MoveNext(Command.Start);
// stateMachine.MoveNext(Command.Process);
// stateMachine.MoveNext(Command.Done);

// Entry();
// static async CustomTask Entry()
// {
//     CustomTask customTask = new(() =>
//     {
//         Thread.Sleep(2000);
//         Console.WriteLine("Inside the action {0}", Thread.CurrentThread.ManagedThreadId);
//     });
//
//     await customTask;
//
//     Console.WriteLine("After CustomTask awaited");
// }
