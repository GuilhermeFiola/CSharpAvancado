using System.IO;
using _00___Bibliotecas;
using System.Xml.Serialization;

namespace _01___SerializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario() { Nome = "Guilherme", CPF = "123.456.789-10", Email = "guilherme@gmail.com" };

            var serializador = new XmlSerializer(typeof(Usuario));
            var writer = new StreamWriter(@"C:\Personal\CSharpAvancado\01 - SerializeXML\XMLOutput\Usuario.xml");

            serializador.Serialize(writer, usuario);
        }
    }
}
