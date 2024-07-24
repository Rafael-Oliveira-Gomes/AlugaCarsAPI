using AlugaCars.Application.Model.Carro;

namespace AlugaCars.Application.Interface
{
    public interface ICarroService
    {
        Task CadastrarCarro(CreateCarroDto CarroDto);
        Task<IEnumerable<ReadCarroDto>> ConsultarCarro(int skip = 0, int take = 20);
        Task<ReadCarroDto> ConsultarCarroPorID(int id);
        Task<bool> AtualizarCarro(int id, CreateCarroDto CarroDto);
        Task<bool> DeletarCarro(int id);
    }
}
