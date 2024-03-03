using System;
using System.Threading;
using System.Threading.Tasks;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public interface IDeleteAsyncRepositoryBase<TEntity, TId> :
        IEntityAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    {
        Task DeleteAsync(TId id, CancellationToken cancellationToken = default);
    }
}
