using Questao5.Domain.Entities;
using Questao5.Domain.Interfaces.Repositories.Base;

namespace Questao5.Domain.Interfaces.Repositories
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        Task<Account> GetActiveAccountById(Guid accountId);
    }
}
