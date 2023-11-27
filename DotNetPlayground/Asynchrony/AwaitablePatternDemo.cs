using System.Runtime.CompilerServices;

namespace Asynchrony;

public class AwaitablePatternDemo
{
    public static CustomAwaitable Run()
    {
        return new CustomAwaitable();
    }
    
    public class CustomAwaitable
    {
        public MyAwaitable GetAwaiter() => new();
    
        public struct MyAwaitable : INotifyCompletion
        {
            public bool IsCompleted { get; }
        
            public void OnCompleted(Action continuation)
            {
                Console.WriteLine("Done!");
                continuation.Invoke();
            }

            public int GetResult()
            {
                return 10;
            }
        }
    }
}