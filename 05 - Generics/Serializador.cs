using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _05___Generics
{
    public class Serializador
    {
        public static void Serializar(Object obj)
        {
            var serializer = new JsonSerializer();

            using (var writer = new StreamWriter(@$"C:\Personal\CSharpAvancado\05 - Generics\Output\05 - Generics - {obj.GetType().Name}.json"))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static T Deserializar<T>()
        {
            var serializador = new JsonSerializer();

            using (var reader = new StreamReader(@$"C:\Personal\CSharpAvancado\05 - Generics\Output\05 - Generics - {typeof(T).Name}.json"))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var retorno = serializador.Deserialize<T>(jsonReader);
                return retorno;
            }
        }
    }
}
