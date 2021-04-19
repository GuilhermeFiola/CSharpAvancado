using System;
using System.Threading;

namespace _19___ThreadMethods
{
    class Program
    {
        static int Compartilhado = 0;
        static object lockCompartilhado = 0;

        static void Main(string[] args)
        {
            // Thread Sleep
            Console.WriteLine("Início");
            Thread.Sleep(3000);
            Console.WriteLine("Fim após 3 segundos");

            // Thread Join
            Console.WriteLine($"Início da repetição de números com variável compartilhada valor: {++Compartilhado}");

            var t1 = new Thread(ThreadRepeticao);
            var t2 = new Thread(ThreadRepeticao);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine($"Fim da repetição de números com join e variável compartilhada valor: {++Compartilhado}");
        }
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Número: {i} | Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            }

            lock (lockCompartilhado)
            {
                ++Compartilhado;
            }
            
        }
    }
}
