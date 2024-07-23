using AlugaCars.Core.Entities;

namespace AlugaCars.DataAcess.Interface
{
    public interface IPagamentoRepository : IBaseRepository<Pagamento>
    {
        Task<IEnumerable<Pagamento>> ConsultarPagamento(int skip, int take);
        Task<Pagamento> ConsultarPagamentoPorID(int id);
    }
}
