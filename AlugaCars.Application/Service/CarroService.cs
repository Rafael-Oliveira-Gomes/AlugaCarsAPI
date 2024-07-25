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

        public async Task<bool> AtualizarCarro(int id, CreateCarroDto carroDto)
        {
            var carro = await _carroRepository.ConsultarCarroPorID(id);
            if (carro == null)
            {
                throw new Exception("Carro não encontrado para atualizar.");
            }

            carro.Update(carroDto.NomeCarro, carroDto.Modelo, carroDto.Ano, carroDto.PrecoPorDia, carroDto.Status);

            return true;
        }

        public async Task CadastrarCarro(CreateCarroDto carroDto)
        {
            //puxar pela api valor do carro da fip
            var carro = new Carro(carroDto.NomeCarro, carroDto.Modelo, carroDto.Ano, carroDto.PrecoPorDia, carroDto.Status);
            await _carroRepository.AddAsync(carro);
        }

        public async Task<IEnumerable<ReadCarroDto>> ConsultarCarro(int skip = 0, int take = 20)
        {
            var todosCarros = await _carroRepository.ConsultarCarros(skip, take);

            return todosCarros.Select(carro => new ReadCarroDto
            {
                Id = carro.Id,
                NomeCarro = carro.NomeCarro,
                Modelo = carro.Modelo,
                Ano = carro.Ano,
                PrecoPorDia = carro.PrecoPorDia,
                Status = carro.Status
            });
        }

        public async Task<ReadCarroDto> ConsultarCarroPorID(int id)
        {
            var carro = await _carroRepository.ConsultarCarroPorID(id);
            if (carro == null)
            {
                throw new Exception("Carro não encontrado para consultar!");
            }

            return new ReadCarroDto
            {
                Id = carro.Id,
                NomeCarro = carro.NomeCarro,
                Modelo = carro.Modelo,
                Ano = carro.Ano,
                PrecoPorDia = carro.PrecoPorDia,
                Status = carro.Status
            };
        }

        public async Task<bool> DeletarCarro(int id)
        {
            var carro = await _carroRepository.ConsultarCarroPorID(id);
            if (carro == null)
            {
                throw new Exception("Carro não encontrado para consultar!");
            }

            await _carroRepository.DeleteAsync(carro);

            return true;
        }
    }
}
