// using System.Runtime.CompilerServices;
//
// namespace AwaitablePattern;
//
// [AsyncMethodBuilder(typeof(CustomTaskMethodBuilder))]
// public class CustomTask
// {
//     public bool IsCompleted { get; set; }
//
//     internal readonly Action _action;
//
//     public CustomTask(Action action) 
//     {
//         _action = action;
//     }
//
//     public CustomAwaiter GetAwaiter() => new(this);
//
//     public void Start()
//     {
//         SynchronizationContext context = SynchronizationContext.Current ?? new();
//
//         Thread thread = new(() =>
//         {
//             _action.Invoke();
//
//             context.Post(_ => Console.WriteLine("From post! {0}", Thread.CurrentThread.ManagedThreadId), null);
//         });
//
//         thread.Start();
//     }
// }
//
// public class CustomAwaiter : INotifyCompletion
// {
//     public bool IsCompleted { get; set; } = false;
//
//     internal readonly CustomTask _customTask;
//
//     public CustomAwaiter(CustomTask customTask) 
//     {
//         _customTask = customTask;
//     }
//
//     public void GetResult()
//     {
//         if (_customTask._action is null || IsCompleted)
//         {
//             return;
//         }
//
//         Console.WriteLine("In the {0} method", nameof(GetResult));
//
//         SynchronizationContext context = SynchronizationContext.Current ?? new();
//
//         Thread thread = new(() =>
//         {
//             _customTask._action.Invoke();
//
//             context.Post(_ => Console.WriteLine("From post!"), null);
//         });
//
//         thread.Start();
//         thread.Join();
//     }
//
//     public void OnCompleted(Action continuation)
//     {
//         Console.WriteLine("In the {0} method", nameof(OnCompleted));
//         _customTask.IsCompleted = true;
//
//         continuation.Invoke();
//     }
// }
//
// public class CustomTaskMethodBuilder
// {
//     private CustomTask _task = null!;
//
//     public CustomTask Task => _task;
//
//     private IAsyncStateMachine? stateMachine;
//     private Exception? exception;
//
//     public static CustomTaskMethodBuilder Create() => new();
//
//     public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
//     {
//         Console.WriteLine("In the {0} method", nameof(Start));
//         SetStateMachine(stateMachine);
//         stateMachine.MoveNext();
//     }
//
//     public void SetStateMachine(IAsyncStateMachine stateMachine) 
//     {
//         Console.WriteLine("In the {0} method", nameof(SetStateMachine));
//         this.stateMachine = stateMachine;
//     }
//
//     public void SetException(Exception exception)
//     {
//         Console.WriteLine("In the {0} method", nameof(SetException));
//         this.exception = exception;
//     }
//
//     public void SetResult() 
//     { 
//         Console.WriteLine("In the {0} method", nameof(SetResult));
//     }
//
//     public void AwaitOnCompleted<TAwaiter, TStateMachine>(
//         ref TAwaiter awaiter, ref TStateMachine stateMachine)
//         where TAwaiter : INotifyCompletion
//         where TStateMachine : IAsyncStateMachine
//     {
//         CustomAwaiter customAwaiter = (awaiter as CustomAwaiter)!;
//         Console.WriteLine("In the {0} method", nameof(AwaitOnCompleted));
//         this.stateMachine = stateMachine;
//         _task = customAwaiter._customTask;
//         awaiter.OnCompleted(() => this.stateMachine.MoveNext());
//     }
//
//     public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
//         ref TAwaiter awaiter, ref TStateMachine stateMachine)
//         where TAwaiter : ICriticalNotifyCompletion
//         where TStateMachine : IAsyncStateMachine
//     {
//         // since we don't implement ICriticalNotifyCompletion, this method won't be used
//     }
// }