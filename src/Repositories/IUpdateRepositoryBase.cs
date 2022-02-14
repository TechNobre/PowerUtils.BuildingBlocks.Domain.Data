using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IUpdateRepositoryBase<TEntity, TId> :
        IEntityRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
