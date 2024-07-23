using AlugaCars.Core.Entities;

namespace AlugaCars.DataAcess.Interface
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        Task<IEnumerable<Reserva>> ConsultarReserva(int skip, int take);
        Task<Reserva> ConsultarReservaPorID(int id);
    }
}
