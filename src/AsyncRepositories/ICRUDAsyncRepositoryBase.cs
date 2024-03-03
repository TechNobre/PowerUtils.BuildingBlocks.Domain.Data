﻿using System;
using PowerUtils.BuildingBlocks.Domain;

namespace PowerUtils.BuildingBlocks.Data.AsyncRepositories
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public interface ICRUDAsyncRepositoryBase<TEntity, TId> :
        IAddAsyncRepositoryBase<TEntity, TId>,
        IGetAsyncRepositoryBase<TEntity, TId>,
        IUpdateAsyncRepositoryBase<TEntity, TId>,
        IDeleteAsyncRepositoryBase<TEntity, TId>

        where TEntity : IAggregateRoot<TId>
    { }
}
