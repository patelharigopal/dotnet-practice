using System;
using System.Threading;

class Test3
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(new ThreadStart(DoWork));
        thread.Start();

        Console.WriteLine("Main thread does some work, then waits.");
        thread.Join();
        Console.WriteLine("Background thread has completed. Main thread ends.");
    }

    static void DoWork()
    {
        Console.WriteLine("Background thread is working.");
        Thread.Sleep(1000);
        Console.WriteLine("Background thread has finished.");
    }
}
