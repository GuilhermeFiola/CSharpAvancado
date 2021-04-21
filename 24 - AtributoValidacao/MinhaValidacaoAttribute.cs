using System.ComponentModel.DataAnnotations;

namespace _24___AtributoValidacao
{
    class MinhaValidacaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (((string)value).Length == 10) return true;
            return false;
        }
    }
}
