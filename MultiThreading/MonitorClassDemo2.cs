using System.Threading;
using System;

public class MonitorClassDemo2
{
    public void M1()
    {
        Monitor.Enter(this);
        try
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Console.WriteLine(i);
                if (i == 3)
                {
                    Monitor.Wait(this, 2000);
                }
            }
        }
        finally
        {
            Monitor.Pulse(this);
            Monitor.Exit(this);
        }
    }
}

public class MonitorClassDemo2
{
    //static void Main(string[] args)
    //{
    //    Test test = new Test();

    //    Thread t1 = new Thread(new ThreadStart(test.M1));
    //    Thread t2 = new Thread(new ThreadStart(test.M1));

    //    t1.Name = "T1";
    //    t2.Name = "T2";

    //    t1.Start();
    //    t2.Start();
    //}
}