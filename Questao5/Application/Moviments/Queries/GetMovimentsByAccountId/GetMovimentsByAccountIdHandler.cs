using Questao5.Application.Abstrations;
using Questao5.Domain.Entities;
using Questao5.Domain.Interfaces.Repositories;

namespace Questao5.Application.Moviments.Queries.GetMovimentsByAccountId
{
    public class GetMovimentsByAccountIdHandler : IQueryHandler<GetMovimentsByAccountIdQuery, List<Moviment>>
    {
        private readonly IMovimentRepository _repository;

        public GetMovimentsByAccountIdHandler(IMovimentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Moviment>> Handle(GetMovimentsByAccountIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetMovimentsByAccountAsync(request.AccountId);
        }
    }
}
