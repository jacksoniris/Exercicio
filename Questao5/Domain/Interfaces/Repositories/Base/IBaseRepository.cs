using Questao5.Domain.Entities.Base;

namespace Questao5.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<TEntity> : IDisposable
       where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(Guid id);
        IQueryable<TEntity> GetAllQueryTracking { get; }
    }
}
