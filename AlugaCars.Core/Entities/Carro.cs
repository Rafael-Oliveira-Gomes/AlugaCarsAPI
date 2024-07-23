namespace AlugaCars.Core.Entities
{
    public class Carro
    {
        public int Id { get; set; }
        public string NomeCarro { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal PrecoPorDia { get; set; }
        public string Status { get; set; }
    }
}
