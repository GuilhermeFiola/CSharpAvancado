using System;

namespace _23___Atributo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    class MeuAtributo : Attribute
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public MeuAtributo(string nome)
        {
            Nome = nome;
        }
    }
}
