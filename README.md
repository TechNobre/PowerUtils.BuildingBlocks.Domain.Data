# PowerUtils.BuildingBlocks.Domain.Data

# :warning: DEPRECATED

This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project.

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/main/assets/logo/logo_128x128.png)

***Provides standard repositories for working with entities***

[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.BuildingBlocks.Domain.Data.svg)](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/blob/main/LICENSE)


- [Support to ](#support-to-)
- [Dependencies ](#dependencies-)
- [How to use ](#how-to-use-)
  - [Install NuGet package ](#install-nuget-package-)
  - [AsyncInterfaces ](#asyncinterfaces-)
    - [IEntityAsyncRepositoryBase ](#ientityasyncrepositorybase-)
    - [IAddAsyncRepositoryBase ](#iaddasyncrepositorybase-)
    - [IUpdateAsyncRepositoryBase ](#iupdateasyncrepositorybase-)
    - [IUpsertAsyncRepositoryBase ](#iupsertasyncrepositorybase-)
    - [IDeleteAsyncRepositoryBase ](#ideleteasyncrepositorybase-)
    - [IGetAsyncRepositoryBase ](#igetasyncrepositorybase-)
    - [IListAsyncRepositoryBase ](#ilistasyncrepositorybase-)
    - [ICountAsyncRepositoryBase ](#icountasyncrepositorybase-)
    - [IAnyAsyncRepositoryBase ](#ianyasyncrepositorybase-)
    - [IPersistentAsyncRepositoryBase ](#ipersistentasyncrepositorybase-)
    - [ICRUDAsyncRepositoryBase ](#icrudasyncrepositorybase-)
    - [IReadAsyncRepositoryBase ](#ireadasyncrepositorybase-)
  - [Interfaces ](#interfaces-)
    - [IEntityRepositoryBase ](#ientityrepositorybase-)
    - [IAddRepositoryBase ](#iaddrepositorybase-)
    - [IUpdateRepositoryBase ](#iupdaterepositorybase-)
    - [IUpsertRepositoryBase ](#iupsertrepositorybase-)
    - [IDeleteRepositoryBase ](#ideleterepositorybase-)
    - [IGetRepositoryBase ](#igetrepositorybase-)
    - [IListRepositoryBase ](#ilistrepositorybase-)
    - [ICountRepositoryBase ](#icountrepositorybase-)
    - [IAnyRepositoryBase ](#ianyrepositorybase-)
    - [IPersistentRepositoryBase ](#ipersistentrepositorybase-)
    - [ICRUDRepositoryBase ](#icrudrepositorybase-)
    - [IReadRepositoryBase ](#ireadrepositorybase-)
- [Contribution ](#contribution-)



## Support to <a name="support-to"></a>
- .NET 6.0
- .NET 5.0
- .NET 3.1



## Dependencies <a name="dependencies"></a>

- PowerUtils.BuildingBlocks.Domain [NuGet](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Domain/)
- PowerUtils.BuildingBlocks.Data [NuGet](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Data/)



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="installation"></a>
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
**namespace:** `PowerUtils.BuildingBlocks.Data.AsyncRepositories`


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


#### IUpsertAsyncRepositoryBase <a name="AsyncInterfaces.IUpsertAsyncRepositoryBase"></a>

```csharp
Task<TId> UpsertAsync(TEntity entity, CancellationToken cancellationToken = default);
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



### Interfaces <a name="Interfaces"></a>
**namespace:** `PowerUtils.BuildingBlocks.Data.Repositories`


#### IEntityRepositoryBase <a name="Interfaces.IEntityRepositoryBase"></a>

```csharp
public interface IEntityRepositoryBase<TEntity, TId> :
    IRepositoryBase

    where TEntity : IAggregateRoot<TId>
{ }
```


#### IAddRepositoryBase <a name="Interfaces.IAddRepositoryBase"></a>

```csharp
TId Add(TEntity entity);
```


#### IUpdateRepositoryBase <a name="Interfaces.IUpdateRepositoryBase"></a>

```csharp
void Update(TEntity entity);
```


#### IUpsertRepositoryBase <a name="Interfaces.IUpsertRepositoryBase"></a>

```csharp
TId Upsert(TEntity entity);
```


#### IDeleteRepositoryBase <a name="Interfaces.IDeleteRepositoryBase"></a>

```csharp
void Delete(TId id);
```


#### IGetRepositoryBase <a name="Interfaces.IGetRepositoryBase"></a>

```csharp
TEntity GetById(TId id);
```


#### IListRepositoryBase <a name="Interfaces.IListRepositoryBase"></a>

```csharp
IEnumerable<TEntity> List();
```


#### ICountRepositoryBase <a name="Interfaces.ICountRepositoryBase"></a>

```csharp
long Count();
```


#### IAnyRepositoryBase <a name="Interfaces.IAnyRepositoryBase"></a>

```csharp
bool Any(TId id);
```


#### IPersistentRepositoryBase <a name="Interfaces.IPersistentRepositoryBase"></a>

```csharp
public interface IPersistentRepositoryBase<TEntity, TId> :
    IEntityRepositoryBase<TEntity, TId>,

    IAddRepositoryBase<TEntity, TId>,
    IUpdateRepositoryBase<TEntity, TId>,
    IDeleteRepositoryBase<TEntity, TId>

    where TEntity : IAggregateRoot<TId>
{
    TId AddOrUpdate(TEntity entity);
}
```


#### ICRUDRepositoryBase <a name="Interfaces.ICRUDRepositoryBase"></a>

```csharp
public interface ICRUDRepositoryBase<TEntity, TId> :
    IEntityRepositoryBase<TEntity, TId>,

    IAddRepositoryBase<TEntity, TId>,
    IGetRepositoryBase<TEntity, TId>,
    IUpdateRepositoryBase<TEntity, TId>,
    IDeleteRepositoryBase<TEntity, TId>

    where TEntity : IAggregateRoot<TId>
{ }
```


#### IReadRepositoryBase <a name="Interfaces.IReadRepositoryBase"></a>

```csharp
public interface IReadRepositoryBase<TEntity, TId> :
    IEntityRepositoryBase<TEntity, TId>,

    IGetRepositoryBase<TEntity, TId>,
    IListRepositoryBase<TEntity, TId>,
    ICountRepositoryBase<TEntity, TId>,
    IAnyRepositoryBase<TEntity, TId>

    where TEntity : IAggregateRoot<TId>
{ }
```



## Contribution <a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/compare)
