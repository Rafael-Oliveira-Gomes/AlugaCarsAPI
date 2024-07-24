using System.ComponentModel.DataAnnotations;

namespace AlugaCars.Application.Model.Carro
{
    public class CreateCarroDto
    {
        [Required]
        public string NomeCarro {  get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public decimal PrecoPorDia { get; set; }
        public string Status { get; set; }
    }
}
