using System;

namespace _08___Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct - Valor
            int i1 = 12345;

            //Objeto - Referência
            object o1 = 123456;

            // Em bancos (MySQL, Oracle, etc) podem exitir valores que podem receber nulo
            Nullable<int> ni1 = 1234;
            int? ni2 = 123; // Sugar Syntax
        }
    }
}
