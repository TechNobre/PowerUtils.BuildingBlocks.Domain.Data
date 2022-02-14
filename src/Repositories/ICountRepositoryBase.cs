using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface ICountRepositoryBase<TEntity, TId> :
        IEntityRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<long> CountAsync(CancellationToken cancellationToken = default);
    }
}
