using AlugaCars.Core.Entities;

namespace AlugaCars.DataAcess.Interface
{
    public interface ICarroRepository : IBaseRepository<Carro>
    {
        Task<IEnumerable<Carro>> ConsultarCarros(int skip, int take);
        Task<Carro> ConsultarCarroPorID(int id);
    }
}
