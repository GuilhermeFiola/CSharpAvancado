using System;
using System.Diagnostics;
using System.Threading;

namespace _16___ThreadsBackground
{
    public class ExecucaoThreads
    {

        public static void Executar()
        {
            var stopwatch = Stopwatch.StartNew();
            Trace.WriteLine("Início");
            ExecucaoComThreads();
            Trace.WriteLine("Fim");
            stopwatch.Stop();
            Trace.WriteLine("ExecucaoComThreads " + stopwatch.ElapsedMilliseconds + "ms");
        }

        static void ExecucaoComThreads()
        {
            Trace.WriteLine("Thread For");
            for (int i = 0; i < 5; i++)
            {
                var thread = new Thread(ThreadRepeticao)
                {
                    // Respeita a execução do método ExecucaoComThreads, quando ele terminar as threads param
                    IsBackground = true
                };
                
                Trace.WriteLine("Thread Start");
                thread.Start();
            }
        }

        static void ThreadRepeticao()
        {
            Trace.WriteLine("Thread Repeticao For");
            for (int i = 0; i < 1000; i++)
            {
                Trace.WriteLine($"Número thread: {i}");
            }
        }
    }
}
