using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IPersistentAsyncRepositoryBase<TEntity, TId> :
        IAddAsyncRepositoryBase<TEntity, TId>,
        IUpdateAsyncRepositoryBase<TEntity, TId>,
        IDeleteAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<TId> AddOrUpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
