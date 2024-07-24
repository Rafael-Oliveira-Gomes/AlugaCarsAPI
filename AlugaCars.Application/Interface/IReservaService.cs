using AlugaCars.Application.Model.Reserva;

namespace AlugaCars.Application.Interface
{
    public interface IReservaService
    {
        Task CadastrarReserva(CreateReservaDto ReservaDto);
        Task<IEnumerable<ReadReservaDto>> ConsultarReserva(int skip = 0, int take = 20);
        Task<ReadReservaDto> ConsultarReservaPorID(int id);
        Task<bool> AtualizarReserva(int id, CreateReservaDto ReservaDto);
        Task<bool> DeletarReserva(int id);
    }
}
