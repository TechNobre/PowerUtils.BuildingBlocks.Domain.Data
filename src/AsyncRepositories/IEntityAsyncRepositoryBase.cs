using PowerUtils.BuildingBlocks.Data.Repositories;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface IEntityAsyncRepositoryBase<TEntity, TId> :
        IRepositoryBase

        where TEntity : IAggregateRoot<TId>
    { }
}
