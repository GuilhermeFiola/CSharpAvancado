using System;
using _00___Bibliotecas;
using System.IO;
using System.Xml.Serialization;

namespace _02___DeserializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Personal\CSharpAvancado\01 - SerializeXML\XMLOutput\Usuario.xml");
            var serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario)serializador.Deserialize(reader);

            Console.WriteLine("Usuário: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
        }
    }
}
