using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface ICRUDAsyncRepositoryBase<TEntity, TId> :
        IAddAsyncRepositoryBase<TEntity, TId>,
        IGetAsyncRepositoryBase<TEntity, TId>,
        IUpdateAsyncRepositoryBase<TEntity, TId>,
        IDeleteAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    { }
}
