using System.ComponentModel.DataAnnotations;
using WebPrimeMotors.Enum;

namespace WebPrimeMotors.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuario")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do usuario")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do usuario")]
        [EmailAddress(ErrorMessage = "O e-mail informado nao e valido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Selecione o perfil do usuario")]
        public PerfilEnum? Perfil { get; set; }
    }
}
