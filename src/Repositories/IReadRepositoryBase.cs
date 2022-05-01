using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IReadRepositoryBase<TEntity, TId> :
        IGetRepositoryBase<TEntity, TId>,
        IListRepositoryBase<TEntity, TId>,
        ICountRepositoryBase<TEntity, TId>,
        IAnyRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    { }
}
