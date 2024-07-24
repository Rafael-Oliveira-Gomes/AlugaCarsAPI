namespace AlugaCars.Application.Model.Reserva
{
    public class ReadReservaDto
    {
        public decimal PrecoTotal { get; set; }
        public DateTime InicioData { get; set; }
        public DateTime FimData { get; set; }
        public int CarroId { get; set; }
        public string Usuario { get; set; }
    }
}
