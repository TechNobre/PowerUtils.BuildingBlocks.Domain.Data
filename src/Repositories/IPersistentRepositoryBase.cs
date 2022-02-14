using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IPersistentRepositoryBase<TEntity, TId> :
        IAddRepositoryBase<TEntity, TId>,
        IUpdateRepositoryBase<TEntity, TId>,
        IDeleteRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<TId> AddOrUpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
