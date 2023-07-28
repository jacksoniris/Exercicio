using Microsoft.EntityFrameworkCore;
using Questao5.Domain.Entities;
using Questao5.Domain.Interfaces.Repositories;
using Questao5.Infrastructure.Database.Context;
using Questao5.Infrastructure.Database.Repositories.Base;

namespace Questao5.Infrastructure.Database.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(ExercicioDbContext context) : base(context)
        {
        }

        public async Task<Account> GetActiveAccountById(Guid accountId)
        {
            return await GetAllQueryTracking.FirstOrDefaultAsync(x => x.Id == accountId && x.Active);
        }
    }
}
