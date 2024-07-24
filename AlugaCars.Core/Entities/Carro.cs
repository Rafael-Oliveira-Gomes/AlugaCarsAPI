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

        public Carro() { }

        public Carro(string nomeCarro, string modelo, int ano, decimal precoPorDia, string status)
        {
            NomeCarro = nomeCarro;
            Modelo = modelo;
            Ano = ano;
            PrecoPorDia = precoPorDia;
            Status = status;
        }

        public void Update(string nomeCarro, string modelo, int ano, decimal precoPorDia, string status)
        {
            NomeCarro = nomeCarro;
            Modelo = modelo;
            Ano = ano;
            PrecoPorDia = precoPorDia;
            Status = status;
        }
    }
    
}
