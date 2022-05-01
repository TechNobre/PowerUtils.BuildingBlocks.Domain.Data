using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface IEntityRepositoryBase<TEntity, TId> :
        IRepositoryBase

        where TEntity : IAggregateRoot<TId>
    { }
}
