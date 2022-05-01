# PowerUtils.BuildingBlocks.Domain.Data
Provides standard repositories for working with entities

![Tests](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/actions/workflows/test-project.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.BuildingBlocks.Domain.Data&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.BuildingBlocks.Domain.Data)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.BuildingBlocks.Domain.Data.svg)](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Domain.Data)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.BuildingBlocks.Domain.Data.svg)](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Domain.Data)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.BuildingBlocks.Domain.Data.svg)](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/blob/main/LICENSE)



## Support to
- .NET 3.1 or more
- .NET Standard 2.1



## Features

- [AsyncInterfaces](#AsyncInterfaces)
  - [IEntityAsyncRepositoryBase](#AsyncInterfaces.IEntityAsyncRepositoryBase)
  - [IAddAsyncRepositoryBase](#AsyncInterfaces.IAddAsyncRepositoryBase)
  - [IUpdateAsyncRepositoryBase](#AsyncInterfaces.IUpdateAsyncRepositoryBase)
  - [IDeleteAsyncRepositoryBase](#AsyncInterfaces.IDeleteAsyncRepositoryBase)
  - [IGetAsyncRepositoryBase](#AsyncInterfaces.IGetAsyncRepositoryBase)
  - [IListAsyncRepositoryBase](#AsyncInterfaces.IListAsyncRepositoryBase)
  - [ICountAsyncRepositoryBase](#AsyncInterfaces.ICountAsyncRepositoryBase)
  - [IAnyAsyncRepositoryBase](#AsyncInterfaces.IAnyAsyncRepositoryBase)
  - [IPersistentAsyncRepositoryBase](#AsyncInterfaces.IPersistentAsyncRepositoryBase)
  - [ICRUDAsyncRepositoryBase](#AsyncInterfaces.ICRUDAsyncRepositoryBase)
  - [IReadAsyncRepositoryBase](#AsyncInterfaces.IReadAsyncRepositoryBase)



## Documentation

### Dependencies

- PowerUtils.BuildingBlocks.Domain [NuGet](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Domain/)
- PowerUtils.BuildingBlocks.Data [NuGet](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Data/)


### How to use

#### Install NuGet package
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Domain.Data

**Nuget**
```bash
Install-Package PowerUtils.BuildingBlocks.Domain.Data
```

**.NET CLI**
```
dotnet add package PowerUtils.BuildingBlocks.Domain.Data
```



### AsyncInterfaces <a name="AsyncInterfaces"></a>


#### IEntityAsyncRepositoryBase <a name="AsyncInterfaces.IEntityAsyncRepositoryBase"></a>

```csharp
public interface IEntityAsyncRepositoryBase<TEntity, TId> :
    IRepositoryBase

    where TEntity : IAggregateRoot<TId>
{ }
```


#### IAddAsyncRepositoryBase <a name="AsyncInterfaces.IAddAsyncRepositoryBase"></a>

```csharp
Task<TId> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
```


#### IUpdateAsyncRepositoryBase <a name="AsyncInterfaces.IUpdateAsyncRepositoryBase"></a>

```csharp
Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
```


#### IDeleteAsyncRepositoryBase <a name="AsyncInterfaces.IDeleteAsyncRepositoryBase"></a>

```csharp
Task DeleteAsync(TId id, CancellationToken cancellationToken = default);
```


#### IGetAsyncRepositoryBase <a name="AsyncInterfaces.IGetAsyncRepositoryBase"></a>

```csharp
Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
```


#### IListAsyncRepositoryBase <a name="AsyncInterfaces.IListAsyncRepositoryBase"></a>

```csharp
Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default);
```


#### ICountAsyncRepositoryBase <a name="AsyncInterfaces.ICountAsyncRepositoryBase"></a>

```csharp
Task<long> CountAsync(CancellationToken cancellationToken = default);
```


#### IAnyAsyncRepositoryBase <a name="AsyncInterfaces.IAnyAsyncRepositoryBase"></a>

```csharp
Task<bool> AnyAsync(TId id, CancellationToken cancellationToken = default);
```


#### IPersistentAsyncRepositoryBase <a name="AsyncInterfaces.IPersistentAsyncRepositoryBase"></a>

```csharp
public interface IPersistentAsyncRepositoryBase<TEntity, TId> :
    IEntityAsyncRepositoryBase<TEntity, TId>,

    IAddAsyncRepositoryBase<TEntity, TId>,
    IUpdateAsyncRepositoryBase<TEntity, TId>,
    IDeleteAsyncRepositoryBase<TEntity, TId>

    where TEntity : IAggregateRoot<TId>
{
    Task<TId> AddOrUpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
}
```


#### ICRUDAsyncRepositoryBase <a name="AsyncInterfaces.ICRUDAsyncRepositoryBase"></a>

```csharp
public interface ICRUDAsyncRepositoryBase<TEntity, TId> :
    IEntityAsyncRepositoryBase<TEntity, TId>,

    IAddAsyncRepositoryBase<TEntity, TId>,
    IGetAsyncRepositoryBase<TEntity, TId>,
    IUpdateAsyncRepositoryBase<TEntity, TId>,
    IDeleteAsyncRepositoryBase<TEntity, TId>

    where TEntity : IAggregateRoot<TId>
{ }
```


#### IReadAsyncRepositoryBase <a name="AsyncInterfaces.IReadAsyncRepositoryBase"></a>

```csharp
public interface IReadAsyncRepositoryBase<TEntity, TId> :
    IEntityAsyncRepositoryBase<TEntity, TId>,

    IGetAsyncRepositoryBase<TEntity, TId>,
    IListAsyncRepositoryBase<TEntity, TId>,
    ICountAsyncRepositoryBase<TEntity, TId>,
    IAnyAsyncRepositoryBase<TEntity, TId>

    where TEntity : IAggregateRoot<TId>
{ }
```



## Contribution

*Help me to help others*



## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/blob/main/LICENSE)



## Changelog

[Here](./CHANGELOG.md)
