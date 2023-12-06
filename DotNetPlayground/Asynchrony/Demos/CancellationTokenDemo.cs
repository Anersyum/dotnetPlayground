namespace Asynchrony.Demos;

internal static class CancellationTokenDemo
{
    public static async Task Run()
    {
        using CancellationTokenSource cts = new();

        Task cancelTask = CancelMePlease(cts.Token);
        
        try
        {
            Console.WriteLine("Press A to cancel:");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                cts.Cancel();
            }
            
            Console.WriteLine();
            await cancelTask;

            if (cancelTask.IsCompletedSuccessfully)
            {
                Console.WriteLine("I'm not canceled!");
            }
        }
        catch (OperationCanceledException e)
        {
            if (cancelTask.IsCanceled)
            {
                Console.WriteLine("Dude, I'm canceled...");
            }
        }
    }

    private static Task CancelMePlease(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.Run(() =>
        {
            Console.WriteLine("Task started!");
            Thread.Sleep(10000);

            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("Cancelling...");
                cancellationToken.ThrowIfCancellationRequested();
            }

            Console.WriteLine("Task completed!");
            
            return Task.CompletedTask;
        }, cancellationToken);
    }
}