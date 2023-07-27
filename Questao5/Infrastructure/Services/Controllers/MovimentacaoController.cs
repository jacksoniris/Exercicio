using Microsoft.AspNetCore.Mvc;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentacaoController : ControllerBase
    {
        private readonly ILogger<MovimentacaoController> _logger;

        public MovimentacaoController(ILogger<MovimentacaoController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult Post()
        {
            return Ok();

        }
    }
}