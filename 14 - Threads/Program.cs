using System;
using System.Threading;

namespace _14___Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(ThreadRepeticao);
            thread1.Start();

            for(int i = 0; i < 1000; i ++)
            {
                Console.WriteLine($"Número: {i}");
            }
        }

        static void ThreadRepeticao()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Número thread: {i}");
            }
        }
    }
}
