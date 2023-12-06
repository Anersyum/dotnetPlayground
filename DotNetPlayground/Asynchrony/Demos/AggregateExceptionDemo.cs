namespace Asynchrony.Demos;

public static class AggregateExceptionDemo
{
    public static async Task Run()
    {
        Task task1 = Task.Run(WorkThatThrowsExceptions);
        Task task2 = Task.Run(WorkThatThrowsExceptions);
        Task task3 = Task.Run(WorkThatThrowsExceptions);

        try
        {
            // Task.WhenAll(task1, task2, task3).Wait();
            await Task.WhenAll(task1, task2, task3);
        }
        catch (AggregateException e)
        {
            Console.WriteLine("AggregateException: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Not AggregateException: {0}", e.Message);
        }
    }

    private static void WorkThatThrowsExceptions()
    {
        int delayMillis = Random.Shared.Next(3000, 6000);

        Thread.Sleep(delayMillis);

        if (delayMillis >= 4500)
        {
            throw new ArgumentException("Argument exception.");
        }

        throw new TimeoutException("Timeout exception.");
    }
}