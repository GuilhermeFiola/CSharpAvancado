using System;

namespace _6___VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = 123456;
            object o2 = "Objeto";

            Console.WriteLine("Object 1: " + o1.ToString());
            Console.WriteLine("Object 2: " + o2.ToString());

            var v1 = 9876;
            var v2 = "Var";
            // Erro: v2 = 123;
            // Erro: var v3;

            Console.WriteLine("Var 1: " + v1.ToString());
            Console.WriteLine("Var 2: " + v2.ToString());

            dynamic d1 = new Usuario() { Nome = "Teste" };

            Console.WriteLine("Dynamic 1: " + d1.Nome);
            // Erro: Console.WriteLine("Dynamic 1: " + d1.Senha);

            d1 = 123456;

            Console.WriteLine("Dynamic 1: " + d1.ToString());
        }

        class Usuario {
            public string Nome { get; set; }
        }
    }
}
