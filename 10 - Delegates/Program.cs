using System;

namespace _10___Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            // Chamada de função
            //var soma = Soma(10, 20);
            //var subtracao = Subtrai(20, 10);

            Calcula funcaoSoma = new Calcula(Soma);
            var soma = funcaoSoma(10, 20);

            Calcula funcaoSubtracao = new Calcula(Subtrai);
            var subtracao = funcaoSubtracao(20, 10);

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");

            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrai(int a, int b)
        {
            return a - b;
        }
    }
}
