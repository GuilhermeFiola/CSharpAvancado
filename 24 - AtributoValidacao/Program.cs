using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _24___AtributoValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario() { Nome = "Guilherme", Email = "guilherme@teste.com", Senha = "1234" };
            var contexto = new ValidationContext(usuario);
            var resultados = new List<ValidationResult>();
            
            if (!Validator.TryValidateObject(usuario, contexto, resultados, true))
            {
                foreach(var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
        }
    }
}
