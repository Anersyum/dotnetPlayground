namespace Asynchrony.Demos;

public static class ContinueWithDemo
{
    public static async Task Run()
    {
        await ContinueWithTaskException();
    }

    private static async Task ContinueWithTaskException()
    {
        Task task = Task.Run(() =>
        {
            Thread.Sleep(2000);
            throw new Exception("Exception");
            Console.WriteLine("Hello from task");
        });

        var t = task.ContinueWith((t) =>
        {
            if (t.IsFaulted)
            {
                Console.WriteLine("Faulty task");
            }
            
            Console.WriteLine("We continue.");
        });

        Console.WriteLine("Before thread sleep");
        Thread.Sleep(4000);
        Console.WriteLine("After thread sleep");
        
        await t;

        // try
        // {
        //     await task;
        // }
        // catch (Exception)
        // {
        //     if (task.IsFaulted)
        //     {
        //         Console.WriteLine("Faulted after await");
        //     }
        // }
        
        Console.WriteLine("Done!");
    }
}