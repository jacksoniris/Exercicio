using Microsoft.EntityFrameworkCore;
using Questao5.Domain.Entities;
using Questao5.Domain.Interfaces.Repositories;
using Questao5.Infrastructure.Database.Context;
using Questao5.Infrastructure.Database.Repositories.Base;

namespace Questao5.Infrastructure.Database.Repositories
{
    public class MovimentRepository : BaseRepository<Moviment>, IMovimentRepository
    {
        public MovimentRepository(ExercicioDbContext context) : base(context) { }

        public async Task<List<Moviment>> GetMovimentsByAccountAsync(Guid accountId)
        {
            return await GetAllQueryTracking.
                Where(x => x.AccountId == accountId).ToListAsync();
        }
    }
}
