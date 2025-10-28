using System.ComponentModel.DataAnnotations;

namespace WebPrimeMotors.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a senha atual do usuario")]
        public string SenhaAtual { get; set; }

        [Required(ErrorMessage = "Digite a nova senha do usuario")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme a senha do usuario")]
        [Compare("NovaSenha", ErrorMessage = "Senha não confere com a nova senha")]
        public string ConfirmarNovaSenha { get; set; }
    }
}
