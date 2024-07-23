using AlugaCars.Core.Entities;
using AlugaCars.DataAcess.Interface;
using AlugaCars.DataAcess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AlugaCars.DataAcess.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(DataContext context) : base(context) { }

        public async Task<IEnumerable<Reserva>> ConsultarReserva(int skip, int take)
        {
            return await _context.Reservas
                 .Include(r => r.Usuario)
                 .Include(r => r.Carro)
                 .Skip(skip)
                 .Take(take)
                 .ToListAsync();
        }

        public async Task<Reserva> ConsultarReservaPorID(int id)
        {
            return await _context.Reservas
                .Include(r => r.Usuario)
                .Include(r => r.Carro)
                .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
