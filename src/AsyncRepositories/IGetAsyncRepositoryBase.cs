using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface IGetAsyncRepositoryBase<TEntity, TId> :
        IEntityAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
    }
}
