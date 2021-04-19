using System;
using System.Diagnostics;
using System.Threading;

namespace _15___MultiThreads
{
    public class ExecucaoThreads
    {

        public static void Executar()
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                ExecucaoComThreads();
            }
            finally
            {
                stopwatch.Stop();
                Trace.WriteLine("ExecucaoComThreads " + stopwatch.ElapsedMilliseconds + "ms");
            }

            stopwatch = Stopwatch.StartNew();
            try
            {
                ExecucaoSemThreads();
            }
            finally
            {
                stopwatch.Stop();
                Trace.WriteLine("ExecucaoSemThreads " + stopwatch.ElapsedMilliseconds + "ms");
            }
        }

        static void ExecucaoComThreads()
        {
            for (int i = 0; i < 5; i++)
            {
                var thread = new Thread(ThreadRepeticao);
                thread.Start();
            }
        }

        static void ExecucaoSemThreads()
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadRepeticao();
            }
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Número thread: {i}");
            }
        }
    }
}
