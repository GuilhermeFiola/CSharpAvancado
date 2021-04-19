using System;
using System.Diagnostics;
using System.Threading;

namespace _18___ThreadId
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < 5; i++)
            {
                var thread1 = new Thread(ThreadRepeticao);
                thread1.Start(i);
            }

            stopwatch.Stop();
            Trace.WriteLine("ExecucaoComThreads " + stopwatch.ElapsedMilliseconds + "ms");
        }

        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Id Loop: {id} | Número: {i} | Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
