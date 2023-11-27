namespace Asynchrony;

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
            throw new Exception("memem");
            Console.WriteLine("Helloi");
        });

        var t = task.ContinueWith((t) =>
        {
            if (t.IsFaulted)
            {
                Console.WriteLine("Faličan");
            }
            Console.WriteLine("Nastavljamo");
        });

        Console.WriteLine("spavamo");
        Thread.Sleep(4000);
        Console.WriteLine("ustali smo");
        await t;

        await task;

        Console.WriteLine("Nastavljamo!");
    }
}