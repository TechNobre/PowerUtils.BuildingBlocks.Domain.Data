using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    public interface IReadAsyncRepositoryBase<TEntity, TId> :
        IGetAsyncRepositoryBase<TEntity, TId>,
        IListAsyncRepositoryBase<TEntity, TId>,
        ICountAsyncRepositoryBase<TEntity, TId>,
        IAnyAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    { }
}
