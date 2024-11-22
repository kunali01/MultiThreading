using System;
using System.Threading;

public class LockKeywordDemo    
{
    public void M1()
    {
        lock (this)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Console.WriteLine(i);
                // Thread.Sleep(2000);
            }
        }
    }
}

public class Program
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
