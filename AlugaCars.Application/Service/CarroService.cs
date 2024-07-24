using AlugaCars.Application.Interface;
using AlugaCars.Application.Model.Carro;
using AlugaCars.Core.Entities;
using AlugaCars.DataAcess.Interface;

namespace AlugaCars.Application.Service
{
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository _carroRepository;

        public CarroService(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public Task<bool> AtualizarCarro(int id, CreateCarroDto CarroDto)
        {
            throw new NotImplementedException();
        }

        public async Task CadastrarCarro(CreateCarroDto carroDto)
        {
            var carro = new Carro(carroDto.NomeCarro, carroDto.Modelo, carroDto.Ano, carroDto.PrecoPorDia, carroDto.Status);
            await _carroRepository.AddAsync(carro);
        }

        public Task<IEnumerable<ReadCarroDto>> ConsultarCarro(int skip = 0, int take = 20)
        {
            throw new NotImplementedException();
        }

        public Task<ReadCarroDto> ConsultarCarroPorID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCarro(int id)
        {
            throw new NotImplementedException();
        }
    }
}
