using AlugaCars.Core.Entities;
using AlugaCars.DataAcess.Interface;
using AlugaCars.DataAcess.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlugaCars.DataAcess.Repositories
{
    public class PagamentoRepository : BaseRepository<Pagamento>, IPagamentoRepository
    {
        public PagamentoRepository(DataContext context) : base(context) { }

        public async Task<IEnumerable<Pagamento>> ConsultarPagamento(int skip, int take)
        {
            return await _context.Pagamentos
                     .Include(p => p.Reserva)
                     .ThenInclude(r => r.Usuario)
                     .Include(p => p.Reserva)
                     .ThenInclude(r => r.Carro)
                     .Skip(skip)
                     .Take(take)
                     .ToListAsync();
        }

        public async Task<Pagamento> ConsultarPagamentoPorID(int id)
        {
            return await _context.Pagamentos
                .Include(p => p.Reserva)
                .ThenInclude(r => r.Usuario)
                .Include(p => p.Reserva)
                .ThenInclude(r => r.Carro)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
