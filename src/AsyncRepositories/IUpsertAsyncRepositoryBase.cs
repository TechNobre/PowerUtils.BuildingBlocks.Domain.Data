using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface IUpsertAsyncRepositoryBase<TEntity, TId> :
        IEntityAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<TId> UpsertAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
