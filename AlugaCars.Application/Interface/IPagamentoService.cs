using AlugaCars.Application.Model.Pagamento;

namespace AlugaCars.Application.Interface
{
    public interface IPagamentoService
    {
        Task CadastrarPagamento(CreatePagamentoDto PagamentoDto);
        Task<IEnumerable<ReadPagamentoDto>> ConsultarPagamento(int skip = 0, int take = 20);
        Task<ReadPagamentoDto> ConsultarPagamentoPorID(int id);
        Task<bool> AtualizarPagamento(int id, CreatePagamentoDto PagamentoDto);
        Task<bool> DeletarPagamento(int id);
    }
}
