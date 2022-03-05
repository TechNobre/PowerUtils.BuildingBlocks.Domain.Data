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

- [Interfaces](#Interfaces)
  - [IEntityRepositoryBase](#Interfaces.IEntityRepositoryBase)
  - [IAddRepositoryBase](#Interfaces.IAddRepositoryBase)
  - [IUpdateRepositoryBase](#Interfaces.IUpdateRepositoryBase)
  - [IDeleteRepositoryBase](#Interfaces.IDeleteRepositoryBase)
  - [IGetRepositoryBase](#Interfaces.IGetRepositoryBase)
  - [IListRepositoryBase](#Interfaces.IListRepositoryBase)
  - [ICountRepositoryBase](#Interfaces.ICountRepositoryBase)
  - [IAnyRepositoryBase](#Interfaces.IAnyRepositoryBase)
  - [IPersistentRepositoryBase](#Interfaces.IPersistentRepositoryBase)
  - [ICRUDRepositoryBase](#Interfaces.ICRUDRepositoryBase)
  - [IReadRepositoryBase](#Interfaces.IReadRepositoryBase)



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



### Interfaces <a name="Interfaces"></a>


#### IEntityRepositoryBase <a name="Interfaces.IEntityRepositoryBase"></a>

```csharp
public interface IEntityRepositoryBase<TEntity, TId> :
    IRepositoryBase

    where TEntity : IAggregateRoot<TId>
{ }
```


#### IAddRepositoryBase <a name="Interfaces.IAddRepositoryBase"></a>

```csharp
Task<TId> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
```


#### IUpdateRepositoryBase <a name="Interfaces.IUpdateRepositoryBase"></a>

```csharp
Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
```


#### IDeleteRepositoryBase <a name="Interfaces.IDeleteRepositoryBase"></a>

```csharp
Task DeleteAsync(TId id, CancellationToken cancellationToken = default);
```


#### IGetRepositoryBase <a name="Interfaces.IGetRepositoryBase"></a>

```csharp
Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
```


#### IListRepositoryBase <a name="Interfaces.IListRepositoryBase"></a>

```csharp
Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default);
```


#### ICountRepositoryBase <a name="Interfaces.ICountRepositoryBase"></a>

```csharp
Task<long> CountAsync(CancellationToken cancellationToken = default);
```


#### IAnyRepositoryBase <a name="Interfaces.IAnyRepositoryBase"></a>

```csharp
Task<bool> AnyAsync(TId id, CancellationToken cancellationToken = default);
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
    Task<TId> AddOrUpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
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



## Contribution

*Help me to help others*



## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Domain.Data/blob/main/LICENSE)



## Changelog

[Here](./CHANGELOG.md)
