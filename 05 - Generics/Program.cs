using System;
using _05___Generics.Modelo;

namespace _05___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro() { Marca = "VW", Modelo = "Golf" };
            var casa = new Casa() { Cidade = "RP", Endereco = "Rua Teste, 500" };
            var usuario = new Usuario() { Nome = "Teste", Email = "teste@teste.com", Senha = "123" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            var novoCarro = Serializador.Deserializar<Carro>();
            var novaCasa = Serializador.Deserializar<Casa>();
            var novoUsuario = Serializador.Deserializar<Usuario>();

            Console.WriteLine(@"Carro: {0} - {1}", novoCarro.Marca, novoCarro.Modelo);
            Console.WriteLine(@"Casa: {0} - {1}", novaCasa.Endereco, novaCasa.Cidade);
            Console.WriteLine(@"Usuario: {0} - {1} - {2}", novoUsuario.Nome, novoUsuario.Email, novoUsuario.Senha);
        }
    }
}
