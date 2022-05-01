using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface IAnyAsyncRepositoryBase<TEntity, TId> :
        IEntityAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<bool> AnyAsync(TId id, CancellationToken cancellationToken = default);
    }
}
