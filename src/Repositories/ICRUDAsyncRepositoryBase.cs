using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.Repositories
{
    public interface ICRUDAsyncRepositoryBase<TEntity, TId> :
        IAddAsyncRepositoryBase<TEntity, TId>,
        IGetAsyncRepositoryBase<TEntity, TId>,
        IUpdateAsyncRepositoryBase<TEntity, TId>,
        IDeleteAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    { }
}
