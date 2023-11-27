namespace Asynchrony;

public static class AggregateExceptionDemo
{
    public static void Run()
    {
        Task task1 = Task.Run(WorkThatThrowsExceptions);
        Task task2 = Task.Run(WorkThatThrowsExceptions);
        Task task3 = Task.Run(WorkThatThrowsExceptions);

        try
        {
            Task.WhenAll(task1, task2, task3).Wait();
        }
        catch (AggregateException e)
        {
            Console.WriteLine("Ojga");
            Console.WriteLine(e);
        }
    }

    private static void WorkThatThrowsExceptions()
    {
        int delayMillis = Random.Shared.Next(3000, 6000);
        
        Thread.Sleep(delayMillis);

        if (delayMillis >= 4500)
        {
            throw new ArgumentException("Break!");
        }

        throw new TimeoutException("Time!");
    }
}