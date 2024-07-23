namespace AlugaCars.Core.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CarroId { get; set; }
        public DateTime InicioData { get; set; }
        public DateTime FimData { get; set; }
        public decimal PrecoTotal { get; set; }

        public Usuario Usuario { get; set; }
        public Carro Carro { get; set; }
    }
}
