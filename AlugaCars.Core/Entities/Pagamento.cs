namespace AlugaCars.Core.Entities
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public decimal Quantia { get; set; }
        public DateTime DataPagamento { get; set; }
        public string MetodoPagamento { get; set; }

        public Reserva Reserva { get; set; }
    }
}
