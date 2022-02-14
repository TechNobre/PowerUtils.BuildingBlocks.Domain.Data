using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IGetRepositoryBase<TEntity, TId> :
        IEntityRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
    }
}
