using System.ComponentModel.DataAnnotations;

namespace WebPrimeMotors.Models
{
    public class VeiculoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do carro")]
        public string Carro { get; set; }

        [Required(ErrorMessage = "Digite o modelo do carro")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Digite a cor do carro")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Digite o ano do carro")]
        public int? Ano { get; set; }

        [Required(ErrorMessage = "Digite a kilometragem do carro")]
        public float? Kilometragem { get; set; }

    }
}
