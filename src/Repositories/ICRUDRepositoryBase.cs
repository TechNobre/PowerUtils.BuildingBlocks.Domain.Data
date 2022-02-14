using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface ICRUDRepositoryBase<TEntity, TId> :
        IAddRepositoryBase<TEntity, TId>,
        IGetRepositoryBase<TEntity, TId>,
        IUpdateRepositoryBase<TEntity, TId>,
        IDeleteRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    { }
}
