namespace AlugaCars.Application.Model.Pagamento
{
    public class CreatePagamentoDto
    {
        public int Desconto { get; set; }
        public DateTime DataPagamento { get; set; }
        public string MetodoPagamento { get; set; }
    }
}
