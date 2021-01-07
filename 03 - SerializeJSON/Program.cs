using System;
using System.IO;
using _00___Bibliotecas;
using Newtonsoft.Json;

namespace _03___SerializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario() { Nome = "Guilherme", CPF = "123.456.789-10", Email = "guilherme@gmail.com" };

            var serializer = new JsonSerializer();

            using (var writer = new StreamWriter(@"C:\Personal\CSharpAvancado\03 - SerializeJSON\JSONOutput\Usuario.json"))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(writer, usuario);
            }
               
        }
    }
}
