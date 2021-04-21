using System.ComponentModel.DataAnnotations;

namespace _24___AtributoValidacao
{
    class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório")]
        [EmailAddress]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO")]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        [MinhaValidacao(ErrorMessage = "Senha deve possuir 10 caracteres")]
        public string Senha { get; set; }
    }
}
