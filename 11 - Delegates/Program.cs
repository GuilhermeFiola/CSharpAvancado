using _11___Delegates.Lib;
using System;

namespace _11___Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tela - Cadastro de Usuários: Thumb (Foto Perfil)
            var fotoPerfil = new Foto() { Nome = "perfil.jpeg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(fotoPerfil);

            // Tela - Cadastro de Produtos: Colorir + Redimensionar
            var fotoProduto = new Foto() { Nome = "produto.jpeg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Filtros = new FotoFiltro().Colorir;
            FotoProcessador.Filtros += new FotoFiltro().Redimensionar;
            FotoProcessador.Processar(fotoProduto);

            // Tela - Cadastro de Albuns Retrô: Preto e Branco
            var fotoRetro = new Foto() { Nome = "retro.jpeg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(fotoRetro);

            //FotoProcessador.Processar(foto);

            Console.ReadKey();
        }
    }
}
