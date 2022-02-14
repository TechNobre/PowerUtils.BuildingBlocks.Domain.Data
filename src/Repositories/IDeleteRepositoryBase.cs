using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IDeleteRepositoryBase<TEntity, TId> :
        IEntityRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task DeleteAsync(TId id, CancellationToken cancellationToken = default);
    }
}
