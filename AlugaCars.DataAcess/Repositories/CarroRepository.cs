using AlugaCars.Core.Entities;
using AlugaCars.DataAcess.Interface;
using AlugaCars.DataAcess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AlugaCars.DataAcess.Repositories
{
    public class CarroRepository : BaseRepository<Carro>, ICarroRepository
    {
        public CarroRepository(DataContext context) : base(context) { }

        public async Task<Carro> ConsultarCarroPorID(int id)
        {
            return await _context.Carros.FindAsync(id);
        }

        public async Task<IEnumerable<Carro>> ConsultarCarros(int skip, int take)
        {
            return await _context.Carros.Skip(skip).Take(take).ToListAsync();
        }

    }
}
