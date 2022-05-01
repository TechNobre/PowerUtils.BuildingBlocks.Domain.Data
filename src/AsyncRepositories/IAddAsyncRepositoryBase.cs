using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface IAddAsyncRepositoryBase<TEntity, TId> :
        IEntityAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<TId> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
