using Questao5.Domain.Entities;
using Questao5.Domain.Interfaces.Repositories.Base;

namespace Questao5.Domain.Interfaces.Repositories
{
    public interface IMovimentRepository : IBaseRepository<Moviment>
    {
        Task<List<Moviment>> GetMovimentsByAccountAsync(Guid accountId);
    }
}
