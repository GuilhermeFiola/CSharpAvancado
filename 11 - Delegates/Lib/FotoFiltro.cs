using System;

namespace _11___Delegates.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine($"Foto Filtro > Colorir > {foto.Nome}");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine($"Foto Filtro > GerarThumb > {foto.Nome}");
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine($"Foto Filtro > PretoBranco > {foto.Nome}");
        }

        public void Redimensionar(Foto foto)
        {
            Console.WriteLine($"Foto Filtro > Redimensionar > {foto.Nome}");
        }
    }
}
