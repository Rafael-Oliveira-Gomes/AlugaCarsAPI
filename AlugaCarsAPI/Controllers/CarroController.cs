using AlugaCars.Application.Interface;
using AlugaCars.Application.Model.Carro;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlugaCarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _carroService;
        private readonly ILogger _logger;

        public CarroController(ICarroService carroService, ILogger logger)
        {
            _carroService = carroService;
            _logger = logger;
        }

        [Authorize(Roles = "Gerente,Admin,User")]
        [HttpPost]
        public async Task<IActionResult> CadastrarCarro([FromBody] CreateCarroDto carroDto)
        {
            try
            {
                await _carroService.CadastrarCarro(carroDto);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "Erro de argumento: {Message}", ex.Message);
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro não tratado: {Message}", ex.Message);
                return StatusCode(500, new { message = "Ocorreu um erro ao cadastrar o carro.", detalhe = ex.Message });
            }

        }
    }
}
