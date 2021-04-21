using _25___Reflection.Modelo;
using System;

namespace _25___Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario() { Nome = "Guilherme", Email = "guilherme@teste.com", Senha = "123456" };

            Log.Gravar(usuario.Clone());

            usuario.Nome = "Guilherme Fiola";
            Log.Gravar(usuario.Clone());

            var carro = new Carro() { Marca = "Volkswagen", Modelo = "Golf" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log foi gravado com sucesso!");
        }
    }
}
