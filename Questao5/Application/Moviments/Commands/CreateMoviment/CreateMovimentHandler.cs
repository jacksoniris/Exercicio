using MediatR;
using Questao5.Application.Abstrations;
using Questao5.Domain.Entities;
using Questao5.Domain.Interfaces.Repositories;

namespace Questao5.Application.Moviments.Commands.CreateUser
{
    public class CreateMovimentHandler : ICommandHandler<CreateMovimentCommand, Guid>
    {
        private readonly IMovimentRepository _repository;

        public CreateMovimentHandler(IMovimentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateMovimentCommand command, CancellationToken cancellationToken)
        {

            var moviment = new Moviment(command.AccountId, command.Type, command.Value);
            var result = await _repository.AddAsync(moviment);
            return result.Id;
        }
    }
}
