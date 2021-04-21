using System;
using System.Collections.Generic;

namespace _25___Reflection
{
    class Log
    {
        public static List<object> objetos = new List<object>();

        public static void Gravar(object obj)
        {
            objetos.Add(obj);
        }

        public static void ApresentarLog()
        {
            foreach(var obj in objetos)
            {
                Console.WriteLine($"----- Nome classe: {obj.GetType().Name} -----");
                foreach(var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
                }
                Console.WriteLine($"---------------------------\n");
            }
        }

        /*
        public static List<Usuario> usuarios = new List<Usuario>();
        
        public static void GravarUsuario(Usuario usuario)
        {
            usuarios.Add((Usuario)usuario.Clone());
        }

        public static void ApresentarLog()
        {
            foreach(var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome} | E-mail: {usuario.Email} | Senha: {usuario.Senha}");
            }
        }
        */
    }
}
