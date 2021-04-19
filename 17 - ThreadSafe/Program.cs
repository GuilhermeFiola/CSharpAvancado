using System;
using System.Diagnostics;
using System.Threading;

namespace _17___ThreadSafe
{
    class Program
    {
        static int Rede = 0;
        static object redeLock = 0;

        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            
            for (int i = 0; i < 5; i++)
            {
                var thread1 = new Thread(ThreadRepeticao);
                thread1.Start();
            }

            stopwatch.Stop();
            Trace.WriteLine("ExecucaoComThreads " + stopwatch.ElapsedMilliseconds + "ms");

            Console.WriteLine($"Rede: {Rede}");
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Número thread: {i}");
                lock (redeLock)
                {
                    Rede++;
                }
            }

            Console.WriteLine($"Rede: {Rede}");
        }
    }
}
