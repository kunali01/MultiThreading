using System;
using System.Threading;

public class Test
{
    public void M1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            // Thread.Sleep(2000);
        }
    }

    public void M2()
    {
        for (int i = 6; i <= 10; i++)
        {
            Console.WriteLine(i);
            // Thread.Sleep(2000);
            // if (i == 7)
            // {
            //     Thread.ResetAbort();
            // }
        }
    }
    static void Main(string[] args)
    {
        Test test = new Test();

        Thread t1 = new Thread(new ThreadStart(test.M1)); // ThreadStart is a delegate
        Thread t2 = new Thread(new ThreadStart(test.M2));

        t1.Priority = ThreadPriority.BelowNormal;
        t2.Priority = ThreadPriority.Highest;

        t1.Start();
        t2.Start();

        t1.Join(); // Next threads will wait until t1 completes
        t2.Join();
    }
}