using _00___Bibliotecas;
using Newtonsoft.Json;
using System;
using System.IO;

namespace _04___DeserializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var serializador = new JsonSerializer();

            using (var reader = new StreamReader(@"C:\Personal\CSharpAvancado\03 - SerializeJSON\JSONOutput\Usuario.json"))
            using(var jsonReader = new JsonTextReader(reader))
            {
                var usuario = serializador.Deserialize<Usuario>(jsonReader);
                Console.WriteLine("Usuário: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            }
                
        }
    }
}
