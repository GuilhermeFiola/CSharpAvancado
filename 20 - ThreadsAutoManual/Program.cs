using System;
using System.Threading;

namespace _20___ThreadsAutoManual
{
    class Program
    {
        static ManualResetEvent manualUm;
        static AutoResetEvent autoDois;

        static void Main(string[] args)
        {
            manualUm = new ManualResetEvent(false);
            var t1 = new Thread(ExecutaUm);
            t1.Start();

            autoDois = new AutoResetEvent(false);
            var t2 = new Thread(ExecutaDois);
            t2.Start();

            // Thread Um
            Thread.Sleep(1000); // Libera a linha "01 - Início execução - Um"
            manualUm.Set();
            manualUm.Reset();
            
            Thread.Sleep(1000);
            manualUm.Set(); // Libera a linha "04 - Finalizado execução - Um"

            // Thread Dois
            Thread.Sleep(2000); // Libera a linha "01 - Início execução - Um"
            autoDois.Set();

            Thread.Sleep(2000);
            autoDois.Set(); // Libera a linha "04 - Finalizado execução - Um"
        }

        static void ExecutaUm()
        {
            Console.WriteLine("01 - Início execução - Um");
            manualUm.WaitOne();
            Console.WriteLine("02 - Em execução - Um");
            Console.WriteLine("03 - Continua execução - Um");
            manualUm.WaitOne();
            Console.WriteLine("04 - Finalizado execução - Um");
        }

        static void ExecutaDois()
        {
            Console.WriteLine("01 - Início execução - Dois");
            autoDois.WaitOne();
            Console.WriteLine("02 - Em execução - Dois");
            Console.WriteLine("03 - Continua execução - Dois");
            autoDois.WaitOne();
            Console.WriteLine("04 - Finalizado execução - Dois");
        }
    }
}
