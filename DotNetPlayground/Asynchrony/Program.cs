using AwaitablePattern;

Console.WriteLine("Current thread {0}", Thread.CurrentThread.ManagedThreadId);

Entry();

//customTask;
//customTask.Start();
//await Task.Delay(4000);


static async CustomTask Entry()
{
    CustomTask customTask = new(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Inside the action {0}", Thread.CurrentThread.ManagedThreadId);
    });

    await customTask;

    Console.WriteLine("After CustomTask awaited");
}