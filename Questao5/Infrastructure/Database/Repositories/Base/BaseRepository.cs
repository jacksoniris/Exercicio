using Microsoft.EntityFrameworkCore;
using Questao5.Domain.Entities.Base;
using Questao5.Domain.Interfaces.Repositories.Base;
using Questao5.Infrastructure.Database.Context;
using System.Threading;

namespace Questao5.Infrastructure.Database.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbSet<TEntity> DbSet { get; set; }
        protected ExercicioDbContext Db { get; }

        public BaseRepository(ExercicioDbContext context)
        {
            Db = context;
            DbSet = context.Set<TEntity>();
        }


        public virtual IQueryable<TEntity> GetAllQueryTracking
        {
            get
            {
                return DbSet.AsQueryable<TEntity>();
            }
        }

 
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            await Db.SaveChangesAsync();
            return entity;
        }


        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
