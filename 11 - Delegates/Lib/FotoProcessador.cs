namespace _11___Delegates.Lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);
        public static FotoFiltroHandler Filtros;

        public static void Processar(Foto foto) => Filtros(foto);

        //public static void Processar(Foto foto)
        //{
        //    var fotoFiltro = new FotoFiltro();

        //    fotoFiltro.Colorir(foto);
        //    fotoFiltro.PretoBranco(foto);
        //    fotoFiltro.GerarThumb(foto);
        //    fotoFiltro.Redimensionar(foto);
        //}
    }
}
