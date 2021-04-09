using System;
using System.Collections.Generic;
using System.Linq;

namespace _09___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1, 3, 9, 5, 20, 15, 45, 70, 90 };

            // Utilizada com Lambda
            var listaFiltradaLambda = lista.Where(w => w > 10).Select(s => s).OrderBy(o => o);

            Console.WriteLine("Lista com lambda: \n");
            foreach (var item in listaFiltradaLambda)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------\n");

            // LINQ
            Console.WriteLine("Lista com LINQ: \n");
            var listaFiltrada = from num in lista where num > 10 orderby num select num;

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------\n");

            // LINQ e objetos

            var listaUsuarios = new List<Usuario>
            {
                new Usuario() { Nome = "Jose", Email = "jose@teste.com" },
                new Usuario() { Nome = "Maria", Email = "maria@teste.com" },
                new Usuario() { Nome = "Guilherme", Email = "guilherme@teste.com" },
                new Usuario() { Nome = "Ana", Email = "ana@gmail.com" },
                new Usuario() { Nome = "Clara", Email = "clara@uol.com" }
            };

            var listaUsuariosFiltrada = listaUsuarios.Where(w => w.Email.Contains("@teste.com"));

            Console.WriteLine("Lista de usuários: \n");
            foreach (var item in listaUsuariosFiltrada)
            {
                Console.WriteLine(string.Concat(item.Nome, " - ", item.Email));
            }
            Console.WriteLine("---------\n");

            // Join

            var listaAutores = new List<Autor>()
            {
                new Autor() { Id = 1, Nome = "Autor 1" },
                new Autor() { Id = 2, Nome = "Autor 2" },
                new Autor() { Id = 3, Nome = "Autor 3" }
            };

            var listaLivros = new List<Livro>
            {
                new Livro() { Id = 1, AutorId = 2, Titulo = "Livro 1", AnoPublicacao = 2000 },
                new Livro() { Id = 2, AutorId = 3, Titulo = "Livro 2", AnoPublicacao = 2010 },
                new Livro() { Id = 3, AutorId = 1, Titulo = "Livro 3", AnoPublicacao = 2020 },
                new Livro() { Id = 4, AutorId = 2, Titulo = "Livro 4", AnoPublicacao = 2021 }
            };

            var listaJoin = from livro in listaLivros
                            join autor in listaAutores
                            on livro.AutorId equals autor.Id
                            select new
                            {
                                nomeAutor = autor.Nome,
                                tituloLivro = livro.Titulo
                            };

            Console.WriteLine("Lista de autores e livros: \n");
            foreach (var item in listaJoin)
            {
                Console.WriteLine(string.Concat(item.nomeAutor, " - ", item.tituloLivro));
            }
            Console.WriteLine("---------\n");

            // Distinct
            int[] listaNumerosRepetidos = { 1, 3, 9, 5, 20, 15, 45, 70, 90, 1, 3, 5, 9, 70, 90 };
            
            var listaDistinct = listaNumerosRepetidos.Distinct();

            Console.WriteLine("Lista distinct: \n");
            foreach (var item in listaDistinct)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------\n");

            var listaGroup = listaNumerosRepetidos.OrderBy(num => num).GroupBy(num => num).Select(num => num);

            Console.WriteLine("Lista group: \n");
            foreach (var item in listaGroup)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("---------\n");

            Console.ReadKey();
        }
    }
}
