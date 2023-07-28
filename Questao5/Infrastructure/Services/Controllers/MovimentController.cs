using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Application.Moviments.Commands.CreateUser;
using Questao5.Application.Moviments.Queries.GetMovimentsByAccountId;
using Questao5.Domain.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentController : ControllerBase
    {
        private readonly ILogger<MovimentController> _logger;
        private readonly IMediator _mediator;


        public MovimentController(ILogger<MovimentController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


        [HttpPost("[Action]")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateMovimentCommand command)
        {

            var result = await _mediator.Send(command);

            return Ok(result);

        }

        [HttpGet("[Action]")]
        public async Task<ActionResult<List<Moviment>>> Balance([FromQuery] GetMovimentsByAccountIdQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);

        }
    }
}