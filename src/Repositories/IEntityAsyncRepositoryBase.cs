using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IEntityAsyncRepositoryBase<TEntity, TId> :
        IRepositoryBase

        where TEntity : IAggregateRoot<TId>
    { }
}
