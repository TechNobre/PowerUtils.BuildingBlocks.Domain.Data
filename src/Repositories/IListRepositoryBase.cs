using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IListRepositoryBase<TEntity, TId> :
        IEntityRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default);
    }
}
