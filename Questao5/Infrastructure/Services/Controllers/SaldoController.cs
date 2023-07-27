using Microsoft.AspNetCore.Mvc;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaldoController : ControllerBase
    {
        private readonly ILogger<MovimentacaoController> _logger;

        public SaldoController(ILogger<MovimentacaoController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok();

        }
    }
}