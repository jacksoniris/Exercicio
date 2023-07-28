using MediatR;
using Questao5.Application.Abstrations;
using Questao5.Domain.Entities;

namespace Questao5.Application.Moviments.Queries.GetMovimentsByAccountId
{
    public class GetMovimentsByAccountIdQuery : IQuery<List<Moviment>>
    {
        public Guid AccountId { get; set; }
    }
}
